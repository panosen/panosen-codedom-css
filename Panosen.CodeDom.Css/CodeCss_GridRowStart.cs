namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// grid-row-start
        /// </summary>
        public string GridRowStart { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set grid-row-start
        /// </summary>
        public static TCodeCss SetGridRowStart<TCodeCss>(this TCodeCss codeCss, string gridRowStart)
            where TCodeCss : CodeCss
        {
            codeCss.GridRowStart = gridRowStart;

            return codeCss;
        }
    }
}
