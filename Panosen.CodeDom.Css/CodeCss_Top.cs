namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// top
        /// </summary>
        public string Top { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set top
        /// </summary>
        public static TCodeCss SetTop<TCodeCss>(this TCodeCss codeCss, string top)
            where TCodeCss : CodeCss
        {
            codeCss.Top = top;

            return codeCss;
        }
    }
}
