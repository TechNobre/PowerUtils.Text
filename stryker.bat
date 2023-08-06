dotnet tool restore
dotnet restore
dotnet build --no-restore
dotnet stryker -tp tests/PowerUtils.Text.Tests/PowerUtils.Text.Tests.csproj --reporter cleartext --reporter html -o