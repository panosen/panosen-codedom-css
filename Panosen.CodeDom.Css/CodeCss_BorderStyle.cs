namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// border-style
        /// </summary>
        public string BorderStyle { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set border-style
        /// </summary>
        public static TCodeCss SetBorderStyle<TCodeCss>(this TCodeCss codeCss, string borderStyle)
            where TCodeCss : CodeCss
        {
            codeCss.BorderStyle = borderStyle;

            return codeCss;
        }
    }
}
