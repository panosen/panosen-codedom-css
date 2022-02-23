namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// outline-color
        /// </summary>
        public string OutlineColor { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set outline-color
        /// </summary>
        public static TCodeCss SetOutlineColor<TCodeCss>(this TCodeCss codeCss, string outlineColor)
            where TCodeCss : CodeCss
        {
            codeCss.OutlineColor = outlineColor;

            return codeCss;
        }
    }
}
