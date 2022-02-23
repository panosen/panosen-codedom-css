namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string ColumnRuleWidth = "column-rule-width";

        private static void GenerateColumnRuleWidth(CodeWriter codeWriter, string columnRuleWidth, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, ColumnRuleWidth, columnRuleWidth, options);
        }
    }
}
