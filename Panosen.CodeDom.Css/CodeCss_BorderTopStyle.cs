namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// border-top-style
        /// </summary>
        public string BorderTopStyle { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set border-top-style
        /// </summary>
        public static TCodeCss SetBorderTopStyle<TCodeCss>(this TCodeCss codeCss, string borderTopStyle)
            where TCodeCss : CodeCss
        {
            codeCss.BorderTopStyle = borderTopStyle;

            return codeCss;
        }
    }
}
