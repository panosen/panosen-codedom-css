namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// grid-column-end
        /// </summary>
        public string GridColumnEnd { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set grid-column-end
        /// </summary>
        public static TCodeCss SetGridColumnEnd<TCodeCss>(this TCodeCss codeCss, string gridColumnEnd)
            where TCodeCss : CodeCss
        {
            codeCss.GridColumnEnd = gridColumnEnd;

            return codeCss;
        }
    }
}
