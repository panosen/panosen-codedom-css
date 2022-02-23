namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// grid
        /// </summary>
        public string Grid { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set grid
        /// </summary>
        public static TCodeCss SetGrid<TCodeCss>(this TCodeCss codeCss, string grid)
            where TCodeCss : CodeCss
        {
            codeCss.Grid = grid;

            return codeCss;
        }
    }
}
