namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// font-synthesis
        /// </summary>
        public string FontSynthesis { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set font-synthesis
        /// </summary>
        public static TCodeCss SetFontSynthesis<TCodeCss>(this TCodeCss codeCss, string fontSynthesis)
            where TCodeCss : CodeCss
        {
            codeCss.FontSynthesis = fontSynthesis;

            return codeCss;
        }
    }
}
