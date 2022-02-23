namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// grid-template
        /// </summary>
        public string GridTemplate { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set grid-template
        /// </summary>
        public static TCodeCss SetGridTemplate<TCodeCss>(this TCodeCss codeCss, string gridTemplate)
            where TCodeCss : CodeCss
        {
            codeCss.GridTemplate = gridTemplate;

            return codeCss;
        }
    }
}
