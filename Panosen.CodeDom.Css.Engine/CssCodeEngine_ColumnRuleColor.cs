namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string ColumnRuleColor = "column-rule-color";

        private static void GenerateColumnRuleColor(CodeWriter codeWriter, string columnRuleColor, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, ColumnRuleColor, columnRuleColor, options);
        }
    }
}
