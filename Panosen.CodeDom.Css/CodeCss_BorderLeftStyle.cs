namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// border-left-style
        /// </summary>
        public string BorderLeftStyle { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set border-left-style
        /// </summary>
        public static TCodeCss SetBorderLeftStyle<TCodeCss>(this TCodeCss codeCss, string borderLeftStyle)
            where TCodeCss : CodeCss
        {
            codeCss.BorderLeftStyle = borderLeftStyle;

            return codeCss;
        }
    }
}
