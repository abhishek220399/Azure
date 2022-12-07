[CmdletBinding()]
param (
    [Parameter(Mandatory, Position = 0)]
    [ValidateSet("PSGallery", "LocalRepo", IgnoreCase = $false, ErrorMessage = "Invalid value for parameter Source.")]
    [string] $Source,

    [Parameter(Mandatory, Position = 1)]
    [ValidateNotNullOrEmpty]
    [ValidateScript({ Test-Path -LiteralPath $_ -PathType Container })]
    [string] $RepoLocation
)

switch ($Source) {
    "PSGallery" {
        Set-PSRepository -Name PSGallery -InstallationPolicy Trusted
        Install-Module -Name Az -Repository PSGallery -Scope CurrentUser -AllowClobber -Force
    }
    "LocalRepo" {
        Register-PSRepository -Name LocalGallery -SourceLocation $RepoLocation -PackageManagementProvider NuGet -InstallationPolicy Trusted
        Install-Module -Name Az -Repository LocalGallery -Scope CurrentUser -AllowClobber -Force
    }
}

Import-Module -Name Az -Force
