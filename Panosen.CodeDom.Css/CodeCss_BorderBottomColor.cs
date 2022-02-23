namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// border-bottom-color
        /// </summary>
        public string BorderBottomColor { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set border-bottom-color
        /// </summary>
        public static TCodeCss SetBorderBottomColor<TCodeCss>(this TCodeCss codeCss, string borderBottomColor)
            where TCodeCss : CodeCss
        {
            codeCss.BorderBottomColor = borderBottomColor;

            return codeCss;
        }
    }
}
