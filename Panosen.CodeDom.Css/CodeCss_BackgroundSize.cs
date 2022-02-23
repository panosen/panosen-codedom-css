namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// background-size
        /// </summary>
        public string BackgroundSize { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set background-size
        /// </summary>
        public static TCodeCss SetBackgroundSize<TCodeCss>(this TCodeCss codeCss, string backgroundSize)
            where TCodeCss : CodeCss
        {
            codeCss.BackgroundSize = backgroundSize;

            return codeCss;
        }
    }
}
