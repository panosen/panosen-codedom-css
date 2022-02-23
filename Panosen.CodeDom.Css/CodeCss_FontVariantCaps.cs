namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// font-variant-caps
        /// </summary>
        public string FontVariantCaps { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set font-variant-caps
        /// </summary>
        public static TCodeCss SetFontVariantCaps<TCodeCss>(this TCodeCss codeCss, string fontVariantCaps)
            where TCodeCss : CodeCss
        {
            codeCss.FontVariantCaps = fontVariantCaps;

            return codeCss;
        }
    }
}
