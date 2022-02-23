namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// font-variant
        /// </summary>
        public string FontVariant { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set font-variant
        /// </summary>
        public static TCodeCss SetFontVariant<TCodeCss>(this TCodeCss codeCss, string fontVariant)
            where TCodeCss : CodeCss
        {
            codeCss.FontVariant = fontVariant;

            return codeCss;
        }
    }
}
