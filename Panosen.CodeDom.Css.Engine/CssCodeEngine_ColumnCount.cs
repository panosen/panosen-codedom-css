namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string ColumnCount = "column-count";

        private static void GenerateColumnCount(CodeWriter codeWriter, string columnCount, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, ColumnCount, columnCount, options);
        }
    }
}
