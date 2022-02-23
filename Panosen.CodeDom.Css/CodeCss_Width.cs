namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// width
        /// </summary>
        public string Width { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set width
        /// </summary>
        public static TCodeCss SetWidth<TCodeCss>(this TCodeCss codeCss, string width)
            where TCodeCss : CodeCss
        {
            codeCss.Width = width;

            return codeCss;
        }
    }
}
