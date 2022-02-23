namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// @font-feature-values
        /// </summary>
        public string FontFeatureValues { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set @font-feature-values
        /// </summary>
        public static TCodeCss SetFontFeatureValues<TCodeCss>(this TCodeCss codeCss, string fontFeatureValues)
            where TCodeCss : CodeCss
        {
            codeCss.FontFeatureValues = fontFeatureValues;

            return codeCss;
        }
    }
}
