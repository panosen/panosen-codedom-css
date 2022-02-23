namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// grid-column-start
        /// </summary>
        public string GridColumnStart { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set grid-column-start
        /// </summary>
        public static TCodeCss SetGridColumnStart<TCodeCss>(this TCodeCss codeCss, string gridColumnStart)
            where TCodeCss : CodeCss
        {
            codeCss.GridColumnStart = gridColumnStart;

            return codeCss;
        }
    }
}
