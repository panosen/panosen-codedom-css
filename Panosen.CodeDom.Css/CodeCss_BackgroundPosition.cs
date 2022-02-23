namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// background-position
        /// </summary>
        public string BackgroundPosition { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set background-position
        /// </summary>
        public static TCodeCss SetBackgroundPosition<TCodeCss>(this TCodeCss codeCss, string backgroundPosition)
            where TCodeCss : CodeCss
        {
            codeCss.BackgroundPosition = backgroundPosition;

            return codeCss;
        }
    }
}
