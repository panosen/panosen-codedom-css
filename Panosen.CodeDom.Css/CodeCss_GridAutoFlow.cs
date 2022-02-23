namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// grid-auto-flow
        /// </summary>
        public string GridAutoFlow { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set grid-auto-flow
        /// </summary>
        public static TCodeCss SetGridAutoFlow<TCodeCss>(this TCodeCss codeCss, string gridAutoFlow)
            where TCodeCss : CodeCss
        {
            codeCss.GridAutoFlow = gridAutoFlow;

            return codeCss;
        }
    }
}
