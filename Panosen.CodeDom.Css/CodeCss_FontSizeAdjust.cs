namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// font-size-adjust
        /// </summary>
        public string FontSizeAdjust { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set font-size-adjust
        /// </summary>
        public static TCodeCss SetFontSizeAdjust<TCodeCss>(this TCodeCss codeCss, string fontSizeAdjust)
            where TCodeCss : CodeCss
        {
            codeCss.FontSizeAdjust = fontSizeAdjust;

            return codeCss;
        }
    }
}
