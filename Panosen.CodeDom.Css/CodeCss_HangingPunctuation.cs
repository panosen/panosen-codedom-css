namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// hanging-punctuation
        /// </summary>
        public string HangingPunctuation { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set hanging-punctuation
        /// </summary>
        public static TCodeCss SetHangingPunctuation<TCodeCss>(this TCodeCss codeCss, string hangingPunctuation)
            where TCodeCss : CodeCss
        {
            codeCss.HangingPunctuation = hangingPunctuation;

            return codeCss;
        }
    }
}
