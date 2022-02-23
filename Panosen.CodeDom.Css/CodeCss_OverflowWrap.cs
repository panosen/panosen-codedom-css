namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// overflow-wrap
        /// </summary>
        public string OverflowWrap { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set overflow-wrap
        /// </summary>
        public static TCodeCss SetOverflowWrap<TCodeCss>(this TCodeCss codeCss, string overflowWrap)
            where TCodeCss : CodeCss
        {
            codeCss.OverflowWrap = overflowWrap;

            return codeCss;
        }
    }
}
