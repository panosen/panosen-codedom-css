namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// break-before
        /// </summary>
        public string BreakBefore { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set break-before
        /// </summary>
        public static TCodeCss SetBreakBefore<TCodeCss>(this TCodeCss codeCss, string breakBefore)
            where TCodeCss : CodeCss
        {
            codeCss.BreakBefore = breakBefore;

            return codeCss;
        }
    }
}
