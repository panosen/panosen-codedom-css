namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string ColumnWidth = "column-width";

        private static void GenerateColumnWidth(CodeWriter codeWriter, string columnWidth, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, ColumnWidth, columnWidth, options);
        }
    }
}
