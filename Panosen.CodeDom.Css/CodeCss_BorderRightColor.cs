namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// border-right-color
        /// </summary>
        public string BorderRightColor { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set border-right-color
        /// </summary>
        public static TCodeCss SetBorderRightColor<TCodeCss>(this TCodeCss codeCss, string borderRightColor)
            where TCodeCss : CodeCss
        {
            codeCss.BorderRightColor = borderRightColor;

            return codeCss;
        }
    }
}
