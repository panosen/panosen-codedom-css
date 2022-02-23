namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// font-style
        /// </summary>
        public string FontStyle { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set font-style
        /// </summary>
        public static TCodeCss SetFontStyle<TCodeCss>(this TCodeCss codeCss, string fontStyle)
            where TCodeCss : CodeCss
        {
            codeCss.FontStyle = fontStyle;

            return codeCss;
        }
    }
}
