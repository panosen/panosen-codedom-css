namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// border-left-color
        /// </summary>
        public string BorderLeftColor { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set border-left-color
        /// </summary>
        public static TCodeCss SetBorderLeftColor<TCodeCss>(this TCodeCss codeCss, string borderLeftColor)
            where TCodeCss : CodeCss
        {
            codeCss.BorderLeftColor = borderLeftColor;

            return codeCss;
        }
    }
}
