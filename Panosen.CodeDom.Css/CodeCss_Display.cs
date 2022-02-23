namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// display
        /// </summary>
        public string Display { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set display
        /// </summary>
        public static TCodeCss SetDisplay<TCodeCss>(this TCodeCss codeCss, string display)
            where TCodeCss : CodeCss
        {
            codeCss.Display = display;

            return codeCss;
        }
    }
}
