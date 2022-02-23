namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// justify-content
        /// </summary>
        public string JustifyContent { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set justify-content
        /// </summary>
        public static TCodeCss SetJustifyContent<TCodeCss>(this TCodeCss codeCss, string justifyContent)
            where TCodeCss : CodeCss
        {
            codeCss.JustifyContent = justifyContent;

            return codeCss;
        }
    }
}
