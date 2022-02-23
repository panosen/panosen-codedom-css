namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// list-style-position
        /// </summary>
        public string ListStylePosition { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set list-style-position
        /// </summary>
        public static TCodeCss SetListStylePosition<TCodeCss>(this TCodeCss codeCss, string listStylePosition)
            where TCodeCss : CodeCss
        {
            codeCss.ListStylePosition = listStylePosition;

            return codeCss;
        }
    }
}
