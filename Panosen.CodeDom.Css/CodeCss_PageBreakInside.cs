namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// page-break-inside
        /// </summary>
        public string PageBreakInside { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set page-break-inside
        /// </summary>
        public static TCodeCss SetPageBreakInside<TCodeCss>(this TCodeCss codeCss, string pageBreakInside)
            where TCodeCss : CodeCss
        {
            codeCss.PageBreakInside = pageBreakInside;

            return codeCss;
        }
    }
}
