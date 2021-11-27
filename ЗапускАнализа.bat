dotnet sonarscanner begin /k:"Rpg_pet" /d:sonar.host.url="http://localhost:9000"  /d:sonar.login="c7540e74846718687ec7b78489efd2892cd32e3a"
dotnet build
dotnet sonarscanner end /d:sonar.login="c7540e74846718687ec7b78489efd2892cd32e3a"