namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// grid-gap
        /// </summary>
        public string GridGap { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set grid-gap
        /// </summary>
        public static TCodeCss SetGridGap<TCodeCss>(this TCodeCss codeCss, string gridGap)
            where TCodeCss : CodeCss
        {
            codeCss.GridGap = gridGap;

            return codeCss;
        }
    }
}
