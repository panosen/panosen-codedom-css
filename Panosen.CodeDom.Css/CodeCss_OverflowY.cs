namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// overflow-y
        /// </summary>
        public string OverflowY { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set overflow-y
        /// </summary>
        public static TCodeCss SetOverflowY<TCodeCss>(this TCodeCss codeCss, string overflowY)
            where TCodeCss : CodeCss
        {
            codeCss.OverflowY = overflowY;

            return codeCss;
        }
    }
}
