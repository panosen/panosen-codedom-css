namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// content
        /// </summary>
        public string Content { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set content
        /// </summary>
        public static TCodeCss SetContent<TCodeCss>(this TCodeCss codeCss, string content)
            where TCodeCss : CodeCss
        {
            codeCss.Content = content;

            return codeCss;
        }
    }
}
