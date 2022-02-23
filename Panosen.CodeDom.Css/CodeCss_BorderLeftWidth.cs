namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// border-left-width
        /// </summary>
        public string BorderLeftWidth { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set border-left-width
        /// </summary>
        public static TCodeCss SetBorderLeftWidth<TCodeCss>(this TCodeCss codeCss, string borderLeftWidth)
            where TCodeCss : CodeCss
        {
            codeCss.BorderLeftWidth = borderLeftWidth;

            return codeCss;
        }
    }
}
