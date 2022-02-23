namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// box-sizing
        /// </summary>
        public string BoxSizing { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set box-sizing
        /// </summary>
        public static TCodeCss SetBoxSizing<TCodeCss>(this TCodeCss codeCss, string boxSizing)
            where TCodeCss : CodeCss
        {
            codeCss.BoxSizing = boxSizing;

            return codeCss;
        }
    }
}
