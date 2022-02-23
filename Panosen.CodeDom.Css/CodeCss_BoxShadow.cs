namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// box-shadow
        /// </summary>
        public string BoxShadow { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set box-shadow
        /// </summary>
        public static TCodeCss SetBoxShadow<TCodeCss>(this TCodeCss codeCss, string boxShadow)
            where TCodeCss : CodeCss
        {
            codeCss.BoxShadow = boxShadow;

            return codeCss;
        }
    }
}
