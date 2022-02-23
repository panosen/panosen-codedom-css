namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string Grid = "grid";

        private static void GenerateGrid(CodeWriter codeWriter, string grid, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, Grid, grid, options);
        }
    }
}
