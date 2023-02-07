@echo off

dotnet restore

dotnet build --no-restore -c Release

move /Y Panosen.CodeDom.Css\bin\Release\Panosen.CodeDom.Css.*.nupkg D:\LocalSavoryNuget\
move /Y Panosen.CodeDom.Css.Engine\bin\Release\Panosen.CodeDom.Css.Engine.*.nupkg D:\LocalSavoryNuget\

pause