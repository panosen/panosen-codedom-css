namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// column-span
        /// </summary>
        public string ColumnSpan { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set column-span
        /// </summary>
        public static TCodeCss SetColumnSpan<TCodeCss>(this TCodeCss codeCss, string columnSpan)
            where TCodeCss : CodeCss
        {
            codeCss.ColumnSpan = columnSpan;

            return codeCss;
        }
    }
}
