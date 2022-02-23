namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// grid-template-columns
        /// </summary>
        public string GridTemplateColumns { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set grid-template-columns
        /// </summary>
        public static TCodeCss SetGridTemplateColumns<TCodeCss>(this TCodeCss codeCss, string gridTemplateColumns)
            where TCodeCss : CodeCss
        {
            codeCss.GridTemplateColumns = gridTemplateColumns;

            return codeCss;
        }
    }
}
