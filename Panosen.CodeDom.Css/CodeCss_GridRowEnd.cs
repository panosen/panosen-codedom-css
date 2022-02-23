namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// grid-row-end
        /// </summary>
        public string GridRowEnd { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set grid-row-end
        /// </summary>
        public static TCodeCss SetGridRowEnd<TCodeCss>(this TCodeCss codeCss, string gridRowEnd)
            where TCodeCss : CodeCss
        {
            codeCss.GridRowEnd = gridRowEnd;

            return codeCss;
        }
    }
}
