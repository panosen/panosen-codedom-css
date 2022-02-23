namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// margin-right
        /// </summary>
        public string MarginRight { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set margin-right
        /// </summary>
        public static TCodeCss SetMarginRight<TCodeCss>(this TCodeCss codeCss, string marginRight)
            where TCodeCss : CodeCss
        {
            codeCss.MarginRight = marginRight;

            return codeCss;
        }
    }
}
