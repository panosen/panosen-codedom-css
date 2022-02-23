namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// border-spacing
        /// </summary>
        public string BorderSpacing { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set border-spacing
        /// </summary>
        public static TCodeCss SetBorderSpacing<TCodeCss>(this TCodeCss codeCss, string borderSpacing)
            where TCodeCss : CodeCss
        {
            codeCss.BorderSpacing = borderSpacing;

            return codeCss;
        }
    }
}
