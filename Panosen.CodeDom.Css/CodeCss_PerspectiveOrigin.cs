namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// perspective-origin
        /// </summary>
        public string PerspectiveOrigin { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set perspective-origin
        /// </summary>
        public static TCodeCss SetPerspectiveOrigin<TCodeCss>(this TCodeCss codeCss, string perspectiveOrigin)
            where TCodeCss : CodeCss
        {
            codeCss.PerspectiveOrigin = perspectiveOrigin;

            return codeCss;
        }
    }
}
