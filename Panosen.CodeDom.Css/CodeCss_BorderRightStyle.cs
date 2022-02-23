namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// border-right-style
        /// </summary>
        public string BorderRightStyle { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set border-right-style
        /// </summary>
        public static TCodeCss SetBorderRightStyle<TCodeCss>(this TCodeCss codeCss, string borderRightStyle)
            where TCodeCss : CodeCss
        {
            codeCss.BorderRightStyle = borderRightStyle;

            return codeCss;
        }
    }
}
