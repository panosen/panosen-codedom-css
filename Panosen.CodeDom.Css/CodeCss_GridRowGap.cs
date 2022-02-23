namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// grid-row-gap
        /// </summary>
        public string GridRowGap { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set grid-row-gap
        /// </summary>
        public static TCodeCss SetGridRowGap<TCodeCss>(this TCodeCss codeCss, string gridRowGap)
            where TCodeCss : CodeCss
        {
            codeCss.GridRowGap = gridRowGap;

            return codeCss;
        }
    }
}
