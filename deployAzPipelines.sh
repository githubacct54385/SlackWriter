 # go to the output dir for the nuget package and push it to nuget
 cd /home/vsts/work/1/a &&
 dotnet nuget push SlackWriter.$(packageVersion).nupkg -k $(NugetApiKey) -s https://api.nuget.org/v3/index.json --skip-duplicate
