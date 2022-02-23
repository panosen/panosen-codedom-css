namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// grid-column-gap
        /// </summary>
        public string GridColumnGap { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set grid-column-gap
        /// </summary>
        public static TCodeCss SetGridColumnGap<TCodeCss>(this TCodeCss codeCss, string gridColumnGap)
            where TCodeCss : CodeCss
        {
            codeCss.GridColumnGap = gridColumnGap;

            return codeCss;
        }
    }
}
