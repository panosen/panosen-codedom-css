namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// column-rule-style
        /// </summary>
        public string ColumnRuleStyle { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set column-rule-style
        /// </summary>
        public static TCodeCss SetColumnRuleStyle<TCodeCss>(this TCodeCss codeCss, string columnRuleStyle)
            where TCodeCss : CodeCss
        {
            codeCss.ColumnRuleStyle = columnRuleStyle;

            return codeCss;
        }
    }
}
