namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// counter-reset
        /// </summary>
        public string CounterReset { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set counter-reset
        /// </summary>
        public static TCodeCss SetCounterReset<TCodeCss>(this TCodeCss codeCss, string counterReset)
            where TCodeCss : CodeCss
        {
            codeCss.CounterReset = counterReset;

            return codeCss;
        }
    }
}
