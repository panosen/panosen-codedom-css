namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// font-stretch
        /// </summary>
        public string FontStretch { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set font-stretch
        /// </summary>
        public static TCodeCss SetFontStretch<TCodeCss>(this TCodeCss codeCss, string fontStretch)
            where TCodeCss : CodeCss
        {
            codeCss.FontStretch = fontStretch;

            return codeCss;
        }
    }
}
