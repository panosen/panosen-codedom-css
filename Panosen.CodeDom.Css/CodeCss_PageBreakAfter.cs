namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// page-break-after
        /// </summary>
        public string PageBreakAfter { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set page-break-after
        /// </summary>
        public static TCodeCss SetPageBreakAfter<TCodeCss>(this TCodeCss codeCss, string pageBreakAfter)
            where TCodeCss : CodeCss
        {
            codeCss.PageBreakAfter = pageBreakAfter;

            return codeCss;
        }
    }
}
