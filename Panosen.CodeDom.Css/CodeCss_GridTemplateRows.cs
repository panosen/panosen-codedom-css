namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// grid-template-rows
        /// </summary>
        public string GridTemplateRows { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set grid-template-rows
        /// </summary>
        public static TCodeCss SetGridTemplateRows<TCodeCss>(this TCodeCss codeCss, string gridTemplateRows)
            where TCodeCss : CodeCss
        {
            codeCss.GridTemplateRows = gridTemplateRows;

            return codeCss;
        }
    }
}
