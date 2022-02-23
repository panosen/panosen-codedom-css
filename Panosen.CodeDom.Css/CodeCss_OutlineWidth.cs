namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// outline-width
        /// </summary>
        public string OutlineWidth { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set outline-width
        /// </summary>
        public static TCodeCss SetOutlineWidth<TCodeCss>(this TCodeCss codeCss, string outlineWidth)
            where TCodeCss : CodeCss
        {
            codeCss.OutlineWidth = outlineWidth;

            return codeCss;
        }
    }
}
