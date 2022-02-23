namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string ColumnRuleStyle = "column-rule-style";

        private static void GenerateColumnRuleStyle(CodeWriter codeWriter, string columnRuleStyle, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, ColumnRuleStyle, columnRuleStyle, options);
        }
    }
}
