namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// border-top
        /// </summary>
        public string BorderTop { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set border-top
        /// </summary>
        public static TCodeCss SetBorderTop<TCodeCss>(this TCodeCss codeCss, string borderTop)
            where TCodeCss : CodeCss
        {
            codeCss.BorderTop = borderTop;

            return codeCss;
        }
    }
}
