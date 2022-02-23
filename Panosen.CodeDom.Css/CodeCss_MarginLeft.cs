namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// margin-left
        /// </summary>
        public string MarginLeft { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set margin-left
        /// </summary>
        public static TCodeCss SetMarginLeft<TCodeCss>(this TCodeCss codeCss, string marginLeft)
            where TCodeCss : CodeCss
        {
            codeCss.MarginLeft = marginLeft;

            return codeCss;
        }
    }
}
