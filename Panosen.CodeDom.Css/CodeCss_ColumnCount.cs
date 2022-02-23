namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// column-count
        /// </summary>
        public string ColumnCount { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set column-count
        /// </summary>
        public static TCodeCss SetColumnCount<TCodeCss>(this TCodeCss codeCss, string columnCount)
            where TCodeCss : CodeCss
        {
            codeCss.ColumnCount = columnCount;

            return codeCss;
        }
    }
}
