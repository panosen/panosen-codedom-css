namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string GridColumn = "grid-column";

        private static void GenerateGridColumn(CodeWriter codeWriter, string gridColumn, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, GridColumn, gridColumn, options);
        }
    }
}
