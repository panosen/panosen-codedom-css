namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// font-weight
        /// </summary>
        public string FontWeight { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set font-weight
        /// </summary>
        public static TCodeCss SetFontWeight<TCodeCss>(this TCodeCss codeCss, string fontWeight)
            where TCodeCss : CodeCss
        {
            codeCss.FontWeight = fontWeight;

            return codeCss;
        }
    }
}
