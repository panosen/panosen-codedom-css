namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// overflow-x
        /// </summary>
        public string OverflowX { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set overflow-x
        /// </summary>
        public static TCodeCss SetOverflowX<TCodeCss>(this TCodeCss codeCss, string overflowX)
            where TCodeCss : CodeCss
        {
            codeCss.OverflowX = overflowX;

            return codeCss;
        }
    }
}
