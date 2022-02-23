namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// grid-auto-columns
        /// </summary>
        public string GridAutoColumns { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set grid-auto-columns
        /// </summary>
        public static TCodeCss SetGridAutoColumns<TCodeCss>(this TCodeCss codeCss, string gridAutoColumns)
            where TCodeCss : CodeCss
        {
            codeCss.GridAutoColumns = gridAutoColumns;

            return codeCss;
        }
    }
}
