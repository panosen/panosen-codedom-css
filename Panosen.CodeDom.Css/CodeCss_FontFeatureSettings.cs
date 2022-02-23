namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// font-feature-settings
        /// </summary>
        public string FontFeatureSettings { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set font-feature-settings
        /// </summary>
        public static TCodeCss SetFontFeatureSettings<TCodeCss>(this TCodeCss codeCss, string fontFeatureSettings)
            where TCodeCss : CodeCss
        {
            codeCss.FontFeatureSettings = fontFeatureSettings;

            return codeCss;
        }
    }
}
