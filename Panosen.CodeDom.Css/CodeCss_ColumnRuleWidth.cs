namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// column-rule-width
        /// </summary>
        public string ColumnRuleWidth { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set column-rule-width
        /// </summary>
        public static TCodeCss SetColumnRuleWidth<TCodeCss>(this TCodeCss codeCss, string columnRuleWidth)
            where TCodeCss : CodeCss
        {
            codeCss.ColumnRuleWidth = columnRuleWidth;

            return codeCss;
        }
    }
}
