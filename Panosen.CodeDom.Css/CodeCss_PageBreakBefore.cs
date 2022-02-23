namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// page-break-before
        /// </summary>
        public string PageBreakBefore { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set page-break-before
        /// </summary>
        public static TCodeCss SetPageBreakBefore<TCodeCss>(this TCodeCss codeCss, string pageBreakBefore)
            where TCodeCss : CodeCss
        {
            codeCss.PageBreakBefore = pageBreakBefore;

            return codeCss;
        }
    }
}
