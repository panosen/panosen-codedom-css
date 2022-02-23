namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// font-language-override
        /// </summary>
        public string FontLanguageOverride { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set font-language-override
        /// </summary>
        public static TCodeCss SetFontLanguageOverride<TCodeCss>(this TCodeCss codeCss, string fontLanguageOverride)
            where TCodeCss : CodeCss
        {
            codeCss.FontLanguageOverride = fontLanguageOverride;

            return codeCss;
        }
    }
}
