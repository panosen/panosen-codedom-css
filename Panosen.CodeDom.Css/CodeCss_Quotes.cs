namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// quotes
        /// </summary>
        public string Quotes { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set quotes
        /// </summary>
        public static TCodeCss SetQuotes<TCodeCss>(this TCodeCss codeCss, string quotes)
            where TCodeCss : CodeCss
        {
            codeCss.Quotes = quotes;

            return codeCss;
        }
    }
}
