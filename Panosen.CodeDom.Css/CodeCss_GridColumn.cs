namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// grid-column
        /// </summary>
        public string GridColumn { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set grid-column
        /// </summary>
        public static TCodeCss SetGridColumn<TCodeCss>(this TCodeCss codeCss, string gridColumn)
            where TCodeCss : CodeCss
        {
            codeCss.GridColumn = gridColumn;

            return codeCss;
        }
    }
}
