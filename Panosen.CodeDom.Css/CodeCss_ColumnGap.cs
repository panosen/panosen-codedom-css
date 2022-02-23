namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// column-gap
        /// </summary>
        public string ColumnGap { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set column-gap
        /// </summary>
        public static TCodeCss SetColumnGap<TCodeCss>(this TCodeCss codeCss, string columnGap)
            where TCodeCss : CodeCss
        {
            codeCss.ColumnGap = columnGap;

            return codeCss;
        }
    }
}
