namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string ColumnRule = "column-rule";

        private static void GenerateColumnRule(CodeWriter codeWriter, string columnRule, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, ColumnRule, columnRule, options);
        }
    }
}
