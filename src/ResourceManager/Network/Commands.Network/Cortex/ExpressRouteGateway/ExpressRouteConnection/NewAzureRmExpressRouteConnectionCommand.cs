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
        ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "ExpressRouteConnection",
        DefaultParameterSetName = CortexParameterSetNames.ByExpressRouteGatewayName,
        SupportsShouldProcess = true),
        OutputType(typeof(PSExpressRouteConnection))]
    public class NewAzureRmExpressRouteConnectionCommand : ExpressRouteConnectionBaseCmdlet
    {
        [Parameter(
            Mandatory = true,
            ParameterSetName = CortexParameterSetNames.ByExpressRouteGatewayName,
            HelpMessage = "The resource group name.")]
        [ResourceGroupCompleter]
        [ValidateNotNullOrEmpty]
        public string ResourceGroupName { get; set; }

        [Alias("ParentExpressRouteGatewayName", "ExpressRouteGatewayName")]
        [Parameter(
            Mandatory = true,
            ParameterSetName = CortexParameterSetNames.ByExpressRouteGatewayName,
            HelpMessage = "The resource group name.")]
        [ValidateNotNullOrEmpty]
        public string ParentResourceName { get; set; }

        [Alias("ParentExpressRouteGateway", "ExpressRouteGateway")]
        [Parameter(
            Mandatory = true,
            ValueFromPipeline = true,
            ParameterSetName = CortexParameterSetNames.ByExpressRouteGatewayObject,
            HelpMessage = "The parent ExpressRouteGateway for this connection.")]
        [ValidateNotNullOrEmpty]
        public PSExpressRouteGateway ParentObject { get; set; }

        [Alias("ParentExpressRouteGatewayId", "ExpressRouteGatewayId")]
        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            ParameterSetName = CortexParameterSetNames.ByExpressRouteGatewayResourceId,
            HelpMessage = "The resource id of the parent ExpressRouteGateway for this connection.")]
        [ValidateNotNullOrEmpty]
        [ResourceIdCompleter("Microsoft.Network/expressRouteGateways")]
        public string ParentResourceId { get; set; }

        [Alias("ResourceName", "ExpressRouteConnectionName")]
        [Parameter(
        Mandatory = true,
        HelpMessage = "The resource name.")]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        [Parameter(
            Mandatory = true,
            HelpMessage = "The Express Route Circuit Peering Id to which this Express Route gateway connection is to be created.")]
        [ValidateNotNullOrEmpty]
        public PSResourceId ExpressRouteCircuitPeering { get; set; }

        [Parameter(
            Mandatory = false,
            HelpMessage = "The authorization key to be used to create the ExpressRoute gateway connection.")]
        [ValidateNotNullOrEmpty]
        public string AuthorizationKey { get; set; }

        [Parameter(
            Mandatory = false,
            HelpMessage = "The Routing Weight for the connection.")]
        public uint RoutingWeight { get; set; }

        [Parameter(
            Mandatory = false,
            HelpMessage = "Run cmdlet in the background")]
        public SwitchParameter AsJob { get; set; }

        public override void Execute()
        {
            base.Execute();

            WriteObject(this.CreateExpressRouteConnection());
        }

        private PSExpressRouteConnection CreateExpressRouteConnection()
        {
            base.Execute();
            PSExpressRouteGateway parentExpressRouteGateway = null;

            //// Resolve the ExpressRouteGateway
            if (ParameterSetName.Contains(CortexParameterSetNames.ByExpressRouteGatewayObject))
            {
                this.ResourceGroupName = this.ParentObject.ResourceGroupName;
                this.ParentResourceName = this.ParentObject.Name;
            }
            else if (ParameterSetName.Contains(CortexParameterSetNames.ByExpressRouteGatewayResourceId))
            {
                var parsedResourceId = new ResourceIdentifier(this.ParentResourceId);
                this.ResourceGroupName = parsedResourceId.ResourceGroupName;
                this.ParentResourceName = parsedResourceId.ResourceName;
            }

            if (string.IsNullOrWhiteSpace(this.ResourceGroupName) || string.IsNullOrWhiteSpace(this.ParentResourceName))
            {
                throw new PSArgumentException(Properties.Resources.ExpressRouteGatewayRequiredToCreateExpressRouteConnection);
            }

            if (this.IsExpressRouteConnectionPresent(this.ResourceGroupName, this.ParentResourceName, this.Name))
            {
                throw new PSArgumentException(string.Format(Properties.Resources.ChildResourceAlreadyPresentInResourceGroup, this.Name, this.ResourceGroupName, this.ParentResourceName));
            }

            //// At this point, we should have the resource name and the resource group for the parent ExpressRouteGateway resolved.
            //// This will throw not found exception if the ExpressRouteGateway does not exist
            parentExpressRouteGateway = this.GetExpressRouteGateway(this.ResourceGroupName, this.ParentResourceName);
            if (parentExpressRouteGateway == null)
            {
                throw new PSArgumentException(Properties.Resources.ParentExpressRouteGatewayNotFound);
            }

            if (parentExpressRouteGateway.Connections == null)
            {
                parentExpressRouteGateway.Connections = new List<PSExpressRouteConnection>();
            }

            PSExpressRouteConnection expressRouteConnection = new PSExpressRouteConnection
            {
                Name = this.Name
            };

            // Set the auth key, if specified
            if (!string.IsNullOrWhiteSpace(this.AuthorizationKey))
            {
                expressRouteConnection.AuthorizationKey = this.AuthorizationKey;
            }

            // Set routing weight, if specified
            if (this.RoutingWeight > 0)
            {
                expressRouteConnection.RoutingWeight = this.RoutingWeight;
            }

            parentExpressRouteGateway.Connections.Add(expressRouteConnection);

            WriteVerbose(string.Format(Properties.Resources.CreatingLongRunningOperationMessage, this.ResourceGroupName, this.Name));

            PSExpressRouteConnection connectionToReturn = null;
            ConfirmAction(
                Properties.Resources.CreatingResourceMessage,
                this.Name,
                () =>
                {
                    WriteVerbose(String.Format(Properties.Resources.CreatingLongRunningOperationMessage, this.ResourceGroupName, this.Name));
                    this.CreateOrUpdateExpressRouteGateway(this.ResourceGroupName, this.ParentResourceName, parentExpressRouteGateway, parentExpressRouteGateway.Tag);

                    var createdOrUpdatedExpressRouteGateway = this.GetExpressRouteGateway(this.ResourceGroupName, this.ParentResourceName);
                    connectionToReturn = createdOrUpdatedExpressRouteGateway.Connections.Where(connection => connection.Name.Equals(this.Name, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
                });

            return connectionToReturn;
        }
    }
}
