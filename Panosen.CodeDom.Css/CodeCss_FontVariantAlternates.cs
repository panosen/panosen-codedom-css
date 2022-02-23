namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// font-variant-alternates
        /// </summary>
        public string FontVariantAlternates { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set font-variant-alternates
        /// </summary>
        public static TCodeCss SetFontVariantAlternates<TCodeCss>(this TCodeCss codeCss, string fontVariantAlternates)
            where TCodeCss : CodeCss
        {
            codeCss.FontVariantAlternates = fontVariantAlternates;

            return codeCss;
        }
    }
}
