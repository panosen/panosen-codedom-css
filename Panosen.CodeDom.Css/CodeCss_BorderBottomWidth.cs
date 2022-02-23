namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// border-bottom-width
        /// </summary>
        public string BorderBottomWidth { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set border-bottom-width
        /// </summary>
        public static TCodeCss SetBorderBottomWidth<TCodeCss>(this TCodeCss codeCss, string borderBottomWidth)
            where TCodeCss : CodeCss
        {
            codeCss.BorderBottomWidth = borderBottomWidth;

            return codeCss;
        }
    }
}
