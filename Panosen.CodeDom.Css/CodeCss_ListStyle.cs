namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// list-style
        /// </summary>
        public string ListStyle { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set list-style
        /// </summary>
        public static TCodeCss SetListStyle<TCodeCss>(this TCodeCss codeCss, string listStyle)
            where TCodeCss : CodeCss
        {
            codeCss.ListStyle = listStyle;

            return codeCss;
        }
    }
}
