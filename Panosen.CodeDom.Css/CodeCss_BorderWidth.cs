namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// border-width
        /// </summary>
        public string BorderWidth { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set border-width
        /// </summary>
        public static TCodeCss SetBorderWidth<TCodeCss>(this TCodeCss codeCss, string borderWidth)
            where TCodeCss : CodeCss
        {
            codeCss.BorderWidth = borderWidth;

            return codeCss;
        }
    }
}
