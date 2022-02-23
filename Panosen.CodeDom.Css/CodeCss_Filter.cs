namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// filter
        /// </summary>
        public string Filter { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set filter
        /// </summary>
        public static TCodeCss SetFilter<TCodeCss>(this TCodeCss codeCss, string filter)
            where TCodeCss : CodeCss
        {
            codeCss.Filter = filter;

            return codeCss;
        }
    }
}
