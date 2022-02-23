namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// tab-size
        /// </summary>
        public string TabSize { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set tab-size
        /// </summary>
        public static TCodeCss SetTabSize<TCodeCss>(this TCodeCss codeCss, string tabSize)
            where TCodeCss : CodeCss
        {
            codeCss.TabSize = tabSize;

            return codeCss;
        }
    }
}
