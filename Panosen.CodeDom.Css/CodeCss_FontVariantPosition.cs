namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// font-variant-position
        /// </summary>
        public string FontVariantPosition { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set font-variant-position
        /// </summary>
        public static TCodeCss SetFontVariantPosition<TCodeCss>(this TCodeCss codeCss, string fontVariantPosition)
            where TCodeCss : CodeCss
        {
            codeCss.FontVariantPosition = fontVariantPosition;

            return codeCss;
        }
    }
}
