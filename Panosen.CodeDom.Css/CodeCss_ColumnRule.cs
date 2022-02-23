namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// column-rule
        /// </summary>
        public string ColumnRule { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set column-rule
        /// </summary>
        public static TCodeCss SetColumnRule<TCodeCss>(this TCodeCss codeCss, string columnRule)
            where TCodeCss : CodeCss
        {
            codeCss.ColumnRule = columnRule;

            return codeCss;
        }
    }
}
