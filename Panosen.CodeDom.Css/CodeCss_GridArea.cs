namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// grid-area
        /// </summary>
        public string GridArea { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set grid-area
        /// </summary>
        public static TCodeCss SetGridArea<TCodeCss>(this TCodeCss codeCss, string gridArea)
            where TCodeCss : CodeCss
        {
            codeCss.GridArea = gridArea;

            return codeCss;
        }
    }
}
