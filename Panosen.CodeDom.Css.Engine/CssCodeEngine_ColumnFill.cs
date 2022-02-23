namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string ColumnFill = "column-fill";

        private static void GenerateColumnFill(CodeWriter codeWriter, string columnFill, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, ColumnFill, columnFill, options);
        }
    }
}
