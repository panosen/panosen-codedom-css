namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// empty-cells
        /// </summary>
        public string EmptyCells { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set empty-cells
        /// </summary>
        public static TCodeCss SetEmptyCells<TCodeCss>(this TCodeCss codeCss, string emptyCells)
            where TCodeCss : CodeCss
        {
            codeCss.EmptyCells = emptyCells;

            return codeCss;
        }
    }
}
