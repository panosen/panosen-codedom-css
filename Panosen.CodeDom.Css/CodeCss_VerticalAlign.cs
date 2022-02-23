namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// vertical-align
        /// </summary>
        public string VerticalAlign { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set vertical-align
        /// </summary>
        public static TCodeCss SetVerticalAlign<TCodeCss>(this TCodeCss codeCss, string verticalAlign)
            where TCodeCss : CodeCss
        {
            codeCss.VerticalAlign = verticalAlign;

            return codeCss;
        }
    }
}
