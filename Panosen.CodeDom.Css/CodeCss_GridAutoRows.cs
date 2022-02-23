namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// grid-auto-rows
        /// </summary>
        public string GridAutoRows { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set grid-auto-rows
        /// </summary>
        public static TCodeCss SetGridAutoRows<TCodeCss>(this TCodeCss codeCss, string gridAutoRows)
            where TCodeCss : CodeCss
        {
            codeCss.GridAutoRows = gridAutoRows;

            return codeCss;
        }
    }
}
