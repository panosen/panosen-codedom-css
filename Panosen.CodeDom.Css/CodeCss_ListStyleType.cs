namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// list-style-type
        /// </summary>
        public string ListStyleType { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set list-style-type
        /// </summary>
        public static TCodeCss SetListStyleType<TCodeCss>(this TCodeCss codeCss, string listStyleType)
            where TCodeCss : CodeCss
        {
            codeCss.ListStyleType = listStyleType;

            return codeCss;
        }
    }
}
