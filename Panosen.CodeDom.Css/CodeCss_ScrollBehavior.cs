namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// scroll-behavior
        /// </summary>
        public string ScrollBehavior { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set scroll-behavior
        /// </summary>
        public static TCodeCss SetScrollBehavior<TCodeCss>(this TCodeCss codeCss, string scrollBehavior)
            where TCodeCss : CodeCss
        {
            codeCss.ScrollBehavior = scrollBehavior;

            return codeCss;
        }
    }
}
