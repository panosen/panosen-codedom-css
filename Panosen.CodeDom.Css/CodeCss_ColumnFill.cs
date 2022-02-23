namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// column-fill
        /// </summary>
        public string ColumnFill { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set column-fill
        /// </summary>
        public static TCodeCss SetColumnFill<TCodeCss>(this TCodeCss codeCss, string columnFill)
            where TCodeCss : CodeCss
        {
            codeCss.ColumnFill = columnFill;

            return codeCss;
        }
    }
}
