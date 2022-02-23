namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// opacity
        /// </summary>
        public string Opacity { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set opacity
        /// </summary>
        public static TCodeCss SetOpacity<TCodeCss>(this TCodeCss codeCss, string opacity)
            where TCodeCss : CodeCss
        {
            codeCss.Opacity = opacity;

            return codeCss;
        }
    }
}
