namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// letter-spacing
        /// </summary>
        public string LetterSpacing { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set letter-spacing
        /// </summary>
        public static TCodeCss SetLetterSpacing<TCodeCss>(this TCodeCss codeCss, string letterSpacing)
            where TCodeCss : CodeCss
        {
            codeCss.LetterSpacing = letterSpacing;

            return codeCss;
        }
    }
}
