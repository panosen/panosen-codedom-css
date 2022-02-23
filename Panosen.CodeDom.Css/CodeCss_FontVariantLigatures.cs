namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// font-variant-ligatures
        /// </summary>
        public string FontVariantLigatures { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set font-variant-ligatures
        /// </summary>
        public static TCodeCss SetFontVariantLigatures<TCodeCss>(this TCodeCss codeCss, string fontVariantLigatures)
            where TCodeCss : CodeCss
        {
            codeCss.FontVariantLigatures = fontVariantLigatures;

            return codeCss;
        }
    }
}
