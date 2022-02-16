cd M01
dotnet build --arch x64;
dotnet build --arch x86;
dotnet pack;
dotnet publish --self-contained true --runtime win-x64;