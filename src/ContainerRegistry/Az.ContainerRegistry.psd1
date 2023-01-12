@{
  GUID = '5bde296f-1161-4779-8562-a6204f035014'
  RootModule = './Az.ContainerRegistry.psm1'
  ModuleVersion = '1.1.0'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = 'Microsoft Corporation'
  CompanyName = 'Microsoft Corporation'
  Copyright = 'Microsoft Corporation. All rights reserved.'
  Description = 'Microsoft Azure PowerShell: ContainerRegistry cmdlets'
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredAssemblies = './bin/Az.ContainerRegistry.private.dll'
  FormatsToProcess = './Az.ContainerRegistry.format.ps1xml'
  FunctionsToExport = 'Get-AzContainerRegistry', 'Get-AzContainerRegistryAgentPool', 'Get-AzContainerRegistryAgentPoolQueueStatus', 'Get-AzContainerRegistryBuildSourceUploadUrl', 'Get-AzContainerRegistryCredentials', 'Get-AzContainerRegistryPrivateEndpointConnection', 'Get-AzContainerRegistryPrivateLinkResource', 'Get-AzContainerRegistryReplication', 'Get-AzContainerRegistryRun', 'Get-AzContainerRegistryRunLogSasUrl', 'Get-AzContainerRegistryScopeMap', 'Get-AzContainerRegistryTask', 'Get-AzContainerRegistryTaskDetail', 'Get-AzContainerRegistryTaskRun', 'Get-AzContainerRegistryTaskRunDetail', 'Get-AzContainerRegistryToken', 'Get-AzContainerRegistryUsage', 'Get-AzContainerRegistryWebhook', 'Get-AzContainerRegistryWebhookCallbackConfig', 'Get-AzContainerRegistryWebhookEvent', 'Import-AzContainerRegistryImage', 'Invoke-AzContainerRegistryScheduleRegistryRun', 'New-AzContainerRegistry', 'New-AzContainerRegistryAgentPool', 'New-AzContainerRegistryCredential', 'New-AzContainerRegistryCredentials', 'New-AzContainerRegistryPrivateEndpointConnection', 'New-AzContainerRegistryReplication', 'New-AzContainerRegistryScopeMap', 'New-AzContainerRegistryTask', 'New-AzContainerRegistryTaskRun', 'New-AzContainerRegistryToken', 'New-AzContainerRegistryWebhook', 'Ping-AzContainerRegistryWebhook', 'Remove-AzContainerRegistry', 'Remove-AzContainerRegistryAgentPool', 'Remove-AzContainerRegistryPrivateEndpointConnection', 'Remove-AzContainerRegistryReplication', 'Remove-AzContainerRegistryScopeMap', 'Remove-AzContainerRegistryTask', 'Remove-AzContainerRegistryTaskRun', 'Remove-AzContainerRegistryToken', 'Remove-AzContainerRegistryWebhook', 'Set-AzContainerRegistryPrivateEndpointConnection', 'Stop-AzContainerRegistryRun', 'Test-AzContainerRegistryNameAvailability', 'Update-AzContainerRegistry', 'Update-AzContainerRegistryAgentPool', 'Update-AzContainerRegistryReplication', 'Update-AzContainerRegistryRun', 'Update-AzContainerRegistryScopeMap', 'Update-AzContainerRegistryTask', 'Update-AzContainerRegistryTaskRun', 'Update-AzContainerRegistryToken', 'Update-AzContainerRegistryWebhook', '*'
  AliasesToExport = '*'
  PrivateData = @{
    PSData = @{
      Tags = 'Azure', 'ResourceManager', 'ARM', 'PSModule', 'ContainerRegistry'
      LicenseUri = 'https://aka.ms/azps-license'
      ProjectUri = 'https://github.com/Azure/azure-powershell'
      ReleaseNotes = ''
    }
  }
}
