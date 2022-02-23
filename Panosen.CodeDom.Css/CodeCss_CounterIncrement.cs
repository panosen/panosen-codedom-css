namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// counter-increment
        /// </summary>
        public string CounterIncrement { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set counter-increment
        /// </summary>
        public static TCodeCss SetCounterIncrement<TCodeCss>(this TCodeCss codeCss, string counterIncrement)
            where TCodeCss : CodeCss
        {
            codeCss.CounterIncrement = counterIncrement;

            return codeCss;
        }
    }
}
