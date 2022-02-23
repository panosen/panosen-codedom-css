namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// border-bottom-style
        /// </summary>
        public string BorderBottomStyle { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set border-bottom-style
        /// </summary>
        public static TCodeCss SetBorderBottomStyle<TCodeCss>(this TCodeCss codeCss, string borderBottomStyle)
            where TCodeCss : CodeCss
        {
            codeCss.BorderBottomStyle = borderBottomStyle;

            return codeCss;
        }
    }
}
