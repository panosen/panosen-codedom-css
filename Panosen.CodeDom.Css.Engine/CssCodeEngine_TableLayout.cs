namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string TableLayout = "table-layout";

        private static void GenerateTableLayout(CodeWriter codeWriter, string tableLayout, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, TableLayout, tableLayout, options);
        }
    }
}
