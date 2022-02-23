namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// border-right-width
        /// </summary>
        public string BorderRightWidth { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set border-right-width
        /// </summary>
        public static TCodeCss SetBorderRightWidth<TCodeCss>(this TCodeCss codeCss, string borderRightWidth)
            where TCodeCss : CodeCss
        {
            codeCss.BorderRightWidth = borderRightWidth;

            return codeCss;
        }
    }
}
