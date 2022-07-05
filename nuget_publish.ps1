$key = $args[0]
$dir = ".\Wakaba2chApiClient\bin\Release\"
$ScriptDir = Split-Path $script:MyInvocation.MyCommand.Path
dotnet build -c Release
dotnet pack -c Release
$latest = Get-ChildItem -Path $dir | Sort-Object LastAccessTime -Descending | Select-Object -First 1
dotnet nuget push "$($dir)$latest" -k $key -s https://api.nuget.org/v3/index.json