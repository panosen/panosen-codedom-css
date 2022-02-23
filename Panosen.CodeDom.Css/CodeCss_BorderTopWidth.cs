namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// border-top-width
        /// </summary>
        public string BorderTopWidth { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set border-top-width
        /// </summary>
        public static TCodeCss SetBorderTopWidth<TCodeCss>(this TCodeCss codeCss, string borderTopWidth)
            where TCodeCss : CodeCss
        {
            codeCss.BorderTopWidth = borderTopWidth;

            return codeCss;
        }
    }
}
