namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// min-width
        /// </summary>
        public string MinWidth { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set min-width
        /// </summary>
        public static TCodeCss SetMinWidth<TCodeCss>(this TCodeCss codeCss, string minWidth)
            where TCodeCss : CodeCss
        {
            codeCss.MinWidth = minWidth;

            return codeCss;
        }
    }
}
