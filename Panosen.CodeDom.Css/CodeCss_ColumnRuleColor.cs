namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// column-rule-color
        /// </summary>
        public string ColumnRuleColor { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set column-rule-color
        /// </summary>
        public static TCodeCss SetColumnRuleColor<TCodeCss>(this TCodeCss codeCss, string columnRuleColor)
            where TCodeCss : CodeCss
        {
            codeCss.ColumnRuleColor = columnRuleColor;

            return codeCss;
        }
    }
}
