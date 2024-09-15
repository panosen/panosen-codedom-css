@echo off

dotnet restore

dotnet build --no-restore -c Release

dotnet nuget push Panosen.CodeDom.Css\bin\Release\Panosen.CodeDom.Css.*.nupkg -s https://nuget.panosen.cn/v3/index.json -k 1cd8e026-9715-3c58-aa2c-42cd087c0b88 --skip-duplicate
dotnet nuget push Panosen.CodeDom.Css.Engine\bin\Release\Panosen.CodeDom.Css.Engine.*.nupkg -s https://nuget.panosen.cn/v3/index.json -k 1cd8e026-9715-3c58-aa2c-42cd087c0b88 --skip-duplicate

move /Y Panosen.CodeDom.Css\bin\Release\Panosen.CodeDom.Css.*.nupkg D:\LocalSavoryNuget\
move /Y Panosen.CodeDom.Css.Engine\bin\Release\Panosen.CodeDom.Css.Engine.*.nupkg D:\LocalSavoryNuget\

pause