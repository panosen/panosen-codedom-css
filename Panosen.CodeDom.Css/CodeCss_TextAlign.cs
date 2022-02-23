namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// text-align
        /// </summary>
        public string TextAlign { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set text-align
        /// </summary>
        public static TCodeCss SetTextAlign<TCodeCss>(this TCodeCss codeCss, string textAlign)
            where TCodeCss : CodeCss
        {
            codeCss.TextAlign = textAlign;

            return codeCss;
        }
    }
}
