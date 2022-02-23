namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// margin-bottom
        /// </summary>
        public string MarginBottom { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set margin-bottom
        /// </summary>
        public static TCodeCss SetMarginBottom<TCodeCss>(this TCodeCss codeCss, string marginBottom)
            where TCodeCss : CodeCss
        {
            codeCss.MarginBottom = marginBottom;

            return codeCss;
        }
    }
}
