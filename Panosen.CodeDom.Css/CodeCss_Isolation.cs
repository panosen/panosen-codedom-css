namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// isolation
        /// </summary>
        public string Isolation { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set isolation
        /// </summary>
        public static TCodeCss SetIsolation<TCodeCss>(this TCodeCss codeCss, string isolation)
            where TCodeCss : CodeCss
        {
            codeCss.Isolation = isolation;

            return codeCss;
        }
    }
}
