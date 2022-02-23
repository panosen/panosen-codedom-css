namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// font-variant-numeric
        /// </summary>
        public string FontVariantNumeric { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set font-variant-numeric
        /// </summary>
        public static TCodeCss SetFontVariantNumeric<TCodeCss>(this TCodeCss codeCss, string fontVariantNumeric)
            where TCodeCss : CodeCss
        {
            codeCss.FontVariantNumeric = fontVariantNumeric;

            return codeCss;
        }
    }
}
