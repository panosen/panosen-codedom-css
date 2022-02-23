namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// outline-style
        /// </summary>
        public string OutlineStyle { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set outline-style
        /// </summary>
        public static TCodeCss SetOutlineStyle<TCodeCss>(this TCodeCss codeCss, string outlineStyle)
            where TCodeCss : CodeCss
        {
            codeCss.OutlineStyle = outlineStyle;

            return codeCss;
        }
    }
}
