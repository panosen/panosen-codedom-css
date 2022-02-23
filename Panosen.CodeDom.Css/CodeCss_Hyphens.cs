namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// hyphens
        /// </summary>
        public string Hyphens { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set hyphens
        /// </summary>
        public static TCodeCss SetHyphens<TCodeCss>(this TCodeCss codeCss, string hyphens)
            where TCodeCss : CodeCss
        {
            codeCss.Hyphens = hyphens;

            return codeCss;
        }
    }
}
