namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// outline
        /// </summary>
        public string Outline { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set outline
        /// </summary>
        public static TCodeCss SetOutline<TCodeCss>(this TCodeCss codeCss, string outline)
            where TCodeCss : CodeCss
        {
            codeCss.Outline = outline;

            return codeCss;
        }
    }
}
