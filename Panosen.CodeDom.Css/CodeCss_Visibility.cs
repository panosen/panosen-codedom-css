namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// visibility
        /// </summary>
        public string Visibility { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set visibility
        /// </summary>
        public static TCodeCss SetVisibility<TCodeCss>(this TCodeCss codeCss, string visibility)
            where TCodeCss : CodeCss
        {
            codeCss.Visibility = visibility;

            return codeCss;
        }
    }
}
