#
# Module manifest for module 'AudioWorks.Commands'
#
# Generated by: Jeremy Herbison
#
# Generated on: 10/18/2017
#

@{

# Script module or binary module file associated with this manifest.
RootModule = 'AudioWorks.Commands.dll'

# Version number of this module.
ModuleVersion = '0.1.0'

# ID used to uniquely identify this module
GUID = '61ec6fd5-82b9-44ce-b058-88707eaed328'

# Author of this module
Author = 'Jeremy Herbison'

# Copyright statement for this module
Copyright = '(c) Jeremy Herbison. All rights reserved.'

# Description of the functionality provided by this module
Description = 'The PowerShell API for AudioWorks - A cross-platform, multi-format audio conversion and tagging suite.'

# Minimum version of the PowerShell engine required by this module
PowerShellVersion = '3.0'

# Minimum version of Microsoft .NET Framework required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
DotNetFrameworkVersion = '4.7.1'

# Format files (.ps1xml) to be loaded when importing this module
FormatsToProcess = @('AudioWorks.Commands.format.ps1xml')

# Functions to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no functions to export.
FunctionsToExport = @()

# Cmdlets to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no cmdlets to export.
CmdletsToExport = @('Get-AudioFile', 'Get-AudioInfo', 'Get-AudioMetadata', 'Set-AudioMetadata', 'Clear-AudioMetadata', 'Save-AudioMetadata', 'Measure-AudioFile')

# Variables to export from this module
VariablesToExport = '*'

# Aliases to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no aliases to export.
AliasesToExport = @()

# Private data to pass to the module specified in RootModule/ModuleToProcess. This may also contain a PSData hashtable with additional module metadata used by PowerShell.
PrivateData = @{

    PSData = @{

        # Tags applied to this module. These help with module discovery in online galleries.
        # Tags = @()

        # A URL to the license for this module.
        LicenseUri = 'https://www.gnu.org/licenses/lgpl-3.0-standalone.html'

        # A URL to the main website for this project.
        ProjectUri = 'https://github.com/jherby2k/AudioWorks'

        # A URL to an icon representing this module.
        # IconUri = ''

        # ReleaseNotes of this module
        # ReleaseNotes = ''

    } # End of PSData hashtable

} # End of PrivateData hashtable

}
