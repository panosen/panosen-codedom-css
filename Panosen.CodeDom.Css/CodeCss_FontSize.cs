namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// font-size
        /// </summary>
        public string FontSize { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set font-size
        /// </summary>
        public static TCodeCss SetFontSize<TCodeCss>(this TCodeCss codeCss, string fontSize)
            where TCodeCss : CodeCss
        {
            codeCss.FontSize = fontSize;

            return codeCss;
        }
    }
}
