namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string ColumnSpan = "column-span";

        private static void GenerateColumnSpan(CodeWriter codeWriter, string columnSpan, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, ColumnSpan, columnSpan, options);
        }
    }
}
