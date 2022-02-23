namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// perspective
        /// </summary>
        public string Perspective { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set perspective
        /// </summary>
        public static TCodeCss SetPerspective<TCodeCss>(this TCodeCss codeCss, string perspective)
            where TCodeCss : CodeCss
        {
            codeCss.Perspective = perspective;

            return codeCss;
        }
    }
}
