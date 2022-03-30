//
// Copyright (c) Microsoft and contributors.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//
// See the License for the specific language governing permissions and
// limitations under the License.
//

// Warning: This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Microsoft.Azure.Commands.Compute.Automation.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.Compute;
using Microsoft.Azure.Management.Compute.Models;
using Microsoft.WindowsAzure.Commands.Utilities.Common;

namespace Microsoft.Azure.Commands.Compute.Automation
{
    [Cmdlet(VerbsDiagnostic.Repair, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "VmssServiceFabricUpdateDomain", DefaultParameterSetName = "DefaultParameter", SupportsShouldProcess = true)]
    [Alias("Repair-" + ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "VmssServiceFabricUD")]
    [OutputType(typeof(PSRecoveryWalkResponse))]
    public partial class RepairAzureRmVmssServiceFabricUpdateDomain : ComputeAutomationBaseCmdlet
    {
        public override void ExecuteCmdlet()
        {
            base.ExecuteCmdlet();
            ExecuteClientAction(() =>
            {
                if (ShouldProcess(this.VMScaleSetName, VerbsDiagnostic.Repair))
                {
                    string resourceGroupName;
                    string vmScaleSetName;
                    string zone = this.Zone;
                    string placementgroupid = this.PlacementGroupId;

                    switch (this.ParameterSetName)
                    {
                        case "ResourceIdParameter":
                            resourceGroupName = GetResourceGroupName(this.ResourceId);
                            vmScaleSetName = GetResourceName(this.ResourceId, "Microsoft.Compute/virtualMachineScaleSets");
                            break;
                        case "ObjectParameter":
                            resourceGroupName = GetResourceGroupName(this.VirtualMachineScaleSet.Id);
                            vmScaleSetName = GetResourceName(this.VirtualMachineScaleSet.Id, "Microsoft.Compute/virtualMachineScaleSets");
                            break;
                        default:
                            resourceGroupName = this.ResourceGroupName;
                            vmScaleSetName = this.VMScaleSetName;
                            break;
                    }
                    int platformUpdateDomain = this.PlatformUpdateDomain;
                    var result = VirtualMachineScaleSetsClient.ForceRecoveryServiceFabricPlatformUpdateDomainWalk(resourceGroupName, vmScaleSetName, platformUpdateDomain, zone: zone, placementGroupId: placementgroupid);
                    var psObject = new PSRecoveryWalkResponse();
                    ComputeAutomationAutoMapperProfile.Mapper.Map<RecoveryWalkResponse, PSRecoveryWalkResponse>(result, psObject);
                    WriteObject(psObject);
                }
            });
        }

        [Parameter(
            ParameterSetName = "DefaultParameter",
            Position = 0,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        [ResourceGroupCompleter]
        public string ResourceGroupName { get; set; }

        [Parameter(
            ParameterSetName = "DefaultParameter",
            Position = 1,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        [ResourceNameCompleter("Microsoft.Compute/virtualMachineScaleSets", "ResourceGroupName")]
        [Alias("Name")]
        public string VMScaleSetName { get; set; }

        [Parameter(
            Position = 2,
            Mandatory = true)]
        public int PlatformUpdateDomain { get; set; }

        [Parameter(
            Mandatory = false,
            HelpMessage = "Set the Zone for the VMSS")]
        public string Zone { get; set; }

        [Parameter(
            Mandatory = false,
            HelpMessage = "Set the Placement Group Id")]
        public string PlacementGroupId { get; set; }

        [Parameter(
            ParameterSetName = "ResourceIdParameter",
            Position = 0,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        public string ResourceId { get; set; }

        [Parameter(
            ParameterSetName = "ObjectParameter",
            Position = 0,
            Mandatory = true,
            ValueFromPipeline = true)]
        [ValidateNotNullOrEmpty]
        public PSVirtualMachineScaleSet VirtualMachineScaleSet { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Run cmdlet in the background")]
        public SwitchParameter AsJob { get; set; }
    }
}
