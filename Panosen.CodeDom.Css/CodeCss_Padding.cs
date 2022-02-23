namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// padding
        /// </summary>
        public string Padding { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set padding
        /// </summary>
        public static TCodeCss SetPadding<TCodeCss>(this TCodeCss codeCss, string padding)
            where TCodeCss : CodeCss
        {
            codeCss.Padding = padding;

            return codeCss;
        }
    }
}
