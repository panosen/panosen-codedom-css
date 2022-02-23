namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// background-color
        /// </summary>
        public string BackgroundColor { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set background-color
        /// </summary>
        public static TCodeCss SetBackgroundColor<TCodeCss>(this TCodeCss codeCss, string backgroundColor)
            where TCodeCss : CodeCss
        {
            codeCss.BackgroundColor = backgroundColor;

            return codeCss;
        }
    }
}
