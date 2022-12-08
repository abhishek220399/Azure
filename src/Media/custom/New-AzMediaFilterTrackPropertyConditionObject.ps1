
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Create an in-memory object for FilterTrackPropertyCondition.
.Description
Create an in-memory object for FilterTrackPropertyCondition.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Media.Models.Api20220801.FilterTrackPropertyCondition
.Link
https://learn.microsoft.com/powershell/module/az.Media/new-AzMediaFilterTrackPropertyConditionObject
#>
function New-AzMediaFilterTrackPropertyConditionObject {
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.Media.Models.Api20220801.FilterTrackPropertyCondition')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter(Mandatory, HelpMessage="The track property condition operation.")]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Media.Support.FilterTrackPropertyCompareOperation])]
        [Microsoft.Azure.PowerShell.Cmdlets.Media.Support.FilterTrackPropertyCompareOperation]
        $Operation,
        [Parameter(Mandatory, HelpMessage="The track property type.")]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Media.Support.FilterTrackPropertyType])]
        [Microsoft.Azure.PowerShell.Cmdlets.Media.Support.FilterTrackPropertyType]
        $Property,
        [Parameter(Mandatory, HelpMessage="The track property value.")]
        [string]
        $Value
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.Media.Models.Api20220801.FilterTrackPropertyCondition]::New()

        if ($PSBoundParameters.ContainsKey('Operation')) {
            $Object.Operation = $Operation
        }
        if ($PSBoundParameters.ContainsKey('Property')) {
            $Object.Property = $Property
        }
        if ($PSBoundParameters.ContainsKey('Value')) {
            $Object.Value = $Value
        }
        return $Object
    }
}

