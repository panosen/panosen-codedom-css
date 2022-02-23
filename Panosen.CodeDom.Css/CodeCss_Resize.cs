namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// resize
        /// </summary>
        public string Resize { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set resize
        /// </summary>
        public static TCodeCss SetResize<TCodeCss>(this TCodeCss codeCss, string resize)
            where TCodeCss : CodeCss
        {
            codeCss.Resize = resize;

            return codeCss;
        }
    }
}
