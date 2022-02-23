namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// border-collapse
        /// </summary>
        public string BorderCollapse { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set border-collapse
        /// </summary>
        public static TCodeCss SetBorderCollapse<TCodeCss>(this TCodeCss codeCss, string borderCollapse)
            where TCodeCss : CodeCss
        {
            codeCss.BorderCollapse = borderCollapse;

            return codeCss;
        }
    }
}
