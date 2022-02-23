namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// font-family
        /// </summary>
        public string FontFamily { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set font-family
        /// </summary>
        public static TCodeCss SetFontFamily<TCodeCss>(this TCodeCss codeCss, string fontFamily)
            where TCodeCss : CodeCss
        {
            codeCss.FontFamily = fontFamily;

            return codeCss;
        }
    }
}
