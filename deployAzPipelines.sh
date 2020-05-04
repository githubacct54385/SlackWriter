cd /home/vsts/work/1/s/SlackWriter.Core/bin/Release
dotnet nuget push SlackWriter.1.0.5.nupkg -k $NUGETAPIKEY -s https://api.nuget.org/v3/index.json
