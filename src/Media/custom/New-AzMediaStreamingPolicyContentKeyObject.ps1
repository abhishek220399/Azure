
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
Create an in-memory object for StreamingPolicyContentKey.
.Description
Create an in-memory object for StreamingPolicyContentKey.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Media.Models.Api20220801.StreamingPolicyContentKey
.Link
https://learn.microsoft.com/powershell/module/az.Media/new-AzMediaStreamingPolicyContentKeyObject
#>
function New-AzMediaStreamingPolicyContentKeyObject {
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.Media.Models.Api20220801.StreamingPolicyContentKey')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter(HelpMessage="Label can be used to specify Content Key when creating a Streaming Locator.")]
        [string]
        $Label,
        [Parameter(HelpMessage="Policy used by Content Key.")]
        [string]
        $PolicyName,
        [Parameter(HelpMessage="Tracks which use this content key.")]
        [Microsoft.Azure.PowerShell.Cmdlets.Media.Models.Api20220801.ITrackSelection[]]
        $Track
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.Media.Models.Api20220801.StreamingPolicyContentKey]::New()

        if ($PSBoundParameters.ContainsKey('Label')) {
            $Object.Label = $Label
        }
        if ($PSBoundParameters.ContainsKey('PolicyName')) {
            $Object.PolicyName = $PolicyName
        }
        if ($PSBoundParameters.ContainsKey('Track')) {
            $Object.Track = $Track
        }
        return $Object
    }
}

