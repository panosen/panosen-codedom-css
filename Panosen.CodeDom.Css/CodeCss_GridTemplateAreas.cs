namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// grid-template-areas
        /// </summary>
        public string GridTemplateAreas { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set grid-template-areas
        /// </summary>
        public static TCodeCss SetGridTemplateAreas<TCodeCss>(this TCodeCss codeCss, string gridTemplateAreas)
            where TCodeCss : CodeCss
        {
            codeCss.GridTemplateAreas = gridTemplateAreas;

            return codeCss;
        }
    }
}
