<#
.SYNOPSIS
	Evergine bindings NuGet Packages generator script.
.DESCRIPTION
	This script generates NuGet packages for the low-level OpenXR bindings used in Evergine
	It's meant to have the same behavior when executed locally as when it's executed in a CI pipeline.
.EXAMPLE
	<script> -version 2021.11.17.1-local
.LINK
	https://evergine.com
#>

param (
	[Parameter(mandatory=$true)][string]$version,
	[string]$outputFolderBase = "nupkgs",
	[string]$buildVerbosity = "normal",
	[string]$buildConfiguration = "Release",
	[string]$openXRGenCsprojPath = "OpenXRGen\OpenXRGen\OpenXRGen.csproj",
	[string]$openXRBindingsCsprojPath = "OpenXRGen\Evergine.Bindings.OpenXR\Evergine.Bindings.OpenXR.csproj"
)

# Utility functions
function LogDebug($line)
{ Write-Host "##[debug] $line" -Foreground Blue -Background Black
}

# Show variables
LogDebug "############## VARIABLES ##############"
LogDebug "Version.............: $version"
LogDebug "Build configuration.: $buildConfiguration"
LogDebug "Build verbosity.....: $buildVerbosity"
LogDebug "Output folder.......: $outputFolderBase"
LogDebug "#######################################"

# Create output folder
$outputFolder = Join-Path $outputFolderBase $versionWithSuffix
New-Item -ItemType Directory -Force -Path $outputFolder
$absoluteOutputFolder = Resolve-Path $outputFolder

$symbols = false
if($buildConfiguration -eq "Debug")
{
	$symbols = true
}

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
pushd .\OpenXRGen\OpenXRGen\bin\Release\netcoreapp3.1
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


# Generate packages
LogDebug "START packaging process"
dotnet pack "$openXRBindingsCsprojPath" -v:$buildVerbosity -p:Configuration=$buildConfiguration -p:PackageOutputPath="$absoluteOutputFolder" -p:IncludeSymbols=$symbols -p:Version=$version
if($?)
{
   LogDebug "END packaging process"
}
else
{
	LogDebug "ERROR; dotnet pack failed"
   	exit -1
}

LogDebug "END packaging process"