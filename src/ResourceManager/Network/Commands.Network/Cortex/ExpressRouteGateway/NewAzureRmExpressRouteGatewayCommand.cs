﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Network
{
    using AutoMapper;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Management.Automation;
    using System.Security;
    using Microsoft.Azure.Commands.Network.Models;
    using Microsoft.Azure.Commands.ResourceManager.Common.Tags;
    using Microsoft.Azure.Management.Network;
    using Microsoft.WindowsAzure.Commands.Common;
    using MNM = Microsoft.Azure.Management.Network.Models;
    using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
    using System.Linq;
    using Microsoft.Azure.Management.Internal.Resources.Utilities.Models;

    [Cmdlet(VerbsCommon.New,
        ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "ExpressRouteGateway",
        DefaultParameterSetName = CortexParameterSetNames.ByVirtualHubName,
        SupportsShouldProcess = true),
        OutputType(typeof(PSExpressRouteGateway))]
    public class NewAzureRmExpressRouteGatewayCommand : ExpressRouteGatewayBaseCmdlet
    {
        [Parameter(
            Mandatory = true,
            HelpMessage = "The resource name.")]
        [ResourceGroupCompleter]
        [ValidateNotNullOrEmpty]
        public string ResourceGroupName { get; set; }

        [Alias("ResourceName", "ExpressRouteGatewayName")]
        [Parameter(
            Mandatory = true,
            HelpMessage = "The resource name.")]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        [Parameter(
            Mandatory = true,
            HelpMessage = "MinBounds for the scale units for this ExpressRouteGateway.")]
        public uint MinBounds { get; set; }

        [Parameter(
            Mandatory = true,
            HelpMessage = "MaxBounds for the scale units for this ExpressRouteGateway.")]
        public uint MaxBounds { get; set; }

        [Parameter(
            Mandatory = true,
            ValueFromPipeline = true,
            ParameterSetName = CortexParameterSetNames.ByVirtualHubObject,
            HelpMessage = "The VirtualHub this ExpressRouteGateway needs to be associated with.")]
        public PSVirtualHub VirtualHub { get; set; }

        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            ParameterSetName = CortexParameterSetNames.ByVirtualHubResourceId,
            HelpMessage = "The Id of the VirtualHub this ExpressRouteGateway needs to be associated with.")]
        [ResourceIdCompleter("Microsoft.Network/virtualHubs")]
        public string VirtualHubId { get; set; }

        [Parameter(
            Mandatory = true,
            ParameterSetName = CortexParameterSetNames.ByVirtualHubName,
            HelpMessage = "The Id of the VirtualHub this ExpressRouteGateway needs to be associated with.")]
        public string VirtualHubName { get; set; }

        [Parameter(
            Mandatory = false,
            HelpMessage = "The list of ExpressRouteConnections that this ExpressRouteGateway needs to have.")]
        public PSExpressRouteConnection[] ExpressRouteConnection { get; set; }

        [Parameter(
            Mandatory = false,
            HelpMessage = "A hashtable which represents resource tags.")]
        public Hashtable Tag { get; set; }

        [Parameter(
            Mandatory = false,
            HelpMessage = "Run cmdlet in the background")]
        public SwitchParameter AsJob { get; set; }

        public override void Execute()
        {
            base.Execute();

            if (this.IsExpressRouteGatewayPresent(this.ResourceGroupName, this.Name))
            {
                throw new PSArgumentException(string.Format(Properties.Resources.ResourceAlreadyPresentInResourceGroup, this.Name, this.ResourceGroupName));
            }

            var expressRouteGateway = new PSExpressRouteGateway();
            expressRouteGateway.Name = this.Name;
            expressRouteGateway.ResourceGroupName = this.ResourceGroupName;
            expressRouteGateway.VirtualHub = null;

            //// Resolve and Set the virtual hub
            if (ParameterSetName.Equals(CortexParameterSetNames.ByVirtualHubObject, StringComparison.OrdinalIgnoreCase))
            {
                this.VirtualHubName = this.VirtualHub.Name;
            }
            else if (ParameterSetName.Equals(CortexParameterSetNames.ByVirtualHubResourceId, StringComparison.OrdinalIgnoreCase))
            {
                var parsedResourceId = new ResourceIdentifier(this.VirtualHubId);
                this.VirtualHubName = parsedResourceId.ResourceName;
            }
            
            //// At this point, we should have the virtual hub name resolved. Fail this operation if it is not.
            if (string.IsNullOrWhiteSpace(this.VirtualHubName))
            {
                throw new PSArgumentException(Properties.Resources.VirtualHubRequiredForExpressRouteGateway);
            }

            var resolvedVirtualHub = new VirtualHubBaseCmdlet().GetVirtualHub(this.ResourceGroupName, this.VirtualHubName);
            expressRouteGateway.Location = resolvedVirtualHub.Location;
            expressRouteGateway.VirtualHub = new PSVirtualHubId() { Id = resolvedVirtualHub.Id };

            //// ExpressRouteConnections, if specified
            expressRouteGateway.Connections = new List<PSExpressRouteConnection>();
            if (this.ExpressRouteConnection != null && this.ExpressRouteConnection.Any())
            {
                expressRouteGateway.Connections.AddRange(this.ExpressRouteConnection);
            }

            if (this.MinBounds > this.MaxBounds)
            {
                throw new PSArgumentException(string.Format(Properties.Resources.InvalidAutoScaleConfiguration, this.MinBounds, this.MaxBounds));
            }

            expressRouteGateway.AutoScaleConfiguration = new PSExpressRouteGatewayAutoscaleConfiguration();
            expressRouteGateway.AutoScaleConfiguration.MinBounds = Convert.ToInt32(this.MinBounds);
            expressRouteGateway.AutoScaleConfiguration.MaxBounds = Convert.ToInt32(this.MaxBounds);

            ConfirmAction(
                Properties.Resources.CreatingResourceMessage,
                this.Name,
                () =>
                {
                    WriteVerbose(String.Format(Properties.Resources.CreatingLongRunningOperationMessage, this.ResourceGroupName, this.Name));
                    WriteObject(this.CreateOrUpdateExpressRouteGateway(this.ResourceGroupName, this.Name, expressRouteGateway, this.Tag));
                });
        }
    }
}
