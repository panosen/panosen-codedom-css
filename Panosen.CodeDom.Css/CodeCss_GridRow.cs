namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// grid-row
        /// </summary>
        public string GridRow { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set grid-row
        /// </summary>
        public static TCodeCss SetGridRow<TCodeCss>(this TCodeCss codeCss, string gridRow)
            where TCodeCss : CodeCss
        {
            codeCss.GridRow = gridRow;

            return codeCss;
        }
    }
}
