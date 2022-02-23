namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// font-variant-east-asian
        /// </summary>
        public string FontVariantEastAsian { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set font-variant-east-asian
        /// </summary>
        public static TCodeCss SetFontVariantEastAsian<TCodeCss>(this TCodeCss codeCss, string fontVariantEastAsian)
            where TCodeCss : CodeCss
        {
            codeCss.FontVariantEastAsian = fontVariantEastAsian;

            return codeCss;
        }
    }
}
