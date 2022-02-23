namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string GridRow = "grid-row";

        private static void GenerateGridRow(CodeWriter codeWriter, string gridRow, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, GridRow, gridRow, options);
        }
    }
}
