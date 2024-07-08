<#
.SYNOPSIS
	Evergine bindings generator script.
.DESCRIPTION
	This script generates a new version of the Binding for OpenXR used in Evergine
	It's meant to have the same behavior when executed locally as when it's executed in a CI pipeline.
.EXAMPLE
	<script>
.LINK
	https://evergine.com
#>

param (
	[string]$buildVerbosity = "normal",
	[string]$buildConfiguration = "Release",
	[string]$openXRGenCsprojPath = "OpenXRGen\OpenXRGen\OpenXRGen.csproj"
)

# Utility functions
function LogDebug($line)
{ Write-Host "##[debug] $line" -Foreground Blue -Background Black
}

# Show variables
LogDebug "############## VARIABLES ##############"
LogDebug "Build configuration.: $buildConfiguration"
LogDebug "Build verbosity.....: $buildVerbosity"
LogDebug "#######################################"

# Compile generator
LogDebug "START generator build process"
dotnet publish -v:$buildVerbosity -p:Configuration=$buildConfiguration $openXRGenCsprojPath
if($?)
{
   LogDebug "END generator build process"
}
else
{
	LogDebug "ERROR; Generator build failed"
   	exit -1
}

# Run generator
LogDebug "START binding generator process"
pushd .\OpenXRGen\OpenXRGen\bin\Release\net6.0
.\publish\OpenXRGen.exe
if($?)
{
   LogDebug "END binding generator process"
}
else
{
	LogDebug "ERROR; Binding Generation failed"
   	exit -1
}
popd
