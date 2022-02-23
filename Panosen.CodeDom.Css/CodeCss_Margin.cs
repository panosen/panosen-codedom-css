namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// margin
        /// </summary>
        public string Margin { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set margin
        /// </summary>
        public static TCodeCss SetMargin<TCodeCss>(this TCodeCss codeCss, string margin)
            where TCodeCss : CodeCss
        {
            codeCss.Margin = margin;

            return codeCss;
        }
    }
}
