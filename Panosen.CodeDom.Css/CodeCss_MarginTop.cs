namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// margin-top
        /// </summary>
        public string MarginTop { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set margin-top
        /// </summary>
        public static TCodeCss SetMarginTop<TCodeCss>(this TCodeCss codeCss, string marginTop)
            where TCodeCss : CodeCss
        {
            codeCss.MarginTop = marginTop;

            return codeCss;
        }
    }
}
