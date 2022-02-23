namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// background-origin
        /// </summary>
        public string BackgroundOrigin { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set background-origin
        /// </summary>
        public static TCodeCss SetBackgroundOrigin<TCodeCss>(this TCodeCss codeCss, string backgroundOrigin)
            where TCodeCss : CodeCss
        {
            codeCss.BackgroundOrigin = backgroundOrigin;

            return codeCss;
        }
    }
}
