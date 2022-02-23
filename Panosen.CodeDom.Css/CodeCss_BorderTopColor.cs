namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// border-top-color
        /// </summary>
        public string BorderTopColor { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set border-top-color
        /// </summary>
        public static TCodeCss SetBorderTopColor<TCodeCss>(this TCodeCss codeCss, string borderTopColor)
            where TCodeCss : CodeCss
        {
            codeCss.BorderTopColor = borderTopColor;

            return codeCss;
        }
    }
}
