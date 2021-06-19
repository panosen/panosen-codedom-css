@echo off

dotnet restore

dotnet build --no-restore -c Release

move /Y Panosen.CodeDom.Css\bin\Release\Panosen.CodeDom.Css.*.nupkg D:\LocalSavoryNuget\

pause