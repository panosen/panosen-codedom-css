namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// break-after
        /// </summary>
        public string BreakAfter { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set break-after
        /// </summary>
        public static TCodeCss SetBreakAfter<TCodeCss>(this TCodeCss codeCss, string breakAfter)
            where TCodeCss : CodeCss
        {
            codeCss.BreakAfter = breakAfter;

            return codeCss;
        }
    }
}
