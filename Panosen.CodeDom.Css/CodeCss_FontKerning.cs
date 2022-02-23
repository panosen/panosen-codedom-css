namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// font-kerning
        /// </summary>
        public string FontKerning { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set font-kerning
        /// </summary>
        public static TCodeCss SetFontKerning<TCodeCss>(this TCodeCss codeCss, string fontKerning)
            where TCodeCss : CodeCss
        {
            codeCss.FontKerning = fontKerning;

            return codeCss;
        }
    }
}
