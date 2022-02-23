namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// column-width
        /// </summary>
        public string ColumnWidth { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set column-width
        /// </summary>
        public static TCodeCss SetColumnWidth<TCodeCss>(this TCodeCss codeCss, string columnWidth)
            where TCodeCss : CodeCss
        {
            codeCss.ColumnWidth = columnWidth;

            return codeCss;
        }
    }
}
