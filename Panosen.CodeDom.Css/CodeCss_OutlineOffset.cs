namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// outline-offset
        /// </summary>
        public string OutlineOffset { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set outline-offset
        /// </summary>
        public static TCodeCss SetOutlineOffset<TCodeCss>(this TCodeCss codeCss, string outlineOffset)
            where TCodeCss : CodeCss
        {
            codeCss.OutlineOffset = outlineOffset;

            return codeCss;
        }
    }
}
