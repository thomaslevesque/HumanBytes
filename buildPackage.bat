@echo off
set OUTDIR=NuGet\bin
mkdir %OUTDIR% 2> nul
nuget pack NuGet\HumanBytes.nuspec -OutputDirectory %OUTDIR%

