namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// overflow
        /// </summary>
        public string Overflow { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set overflow
        /// </summary>
        public static TCodeCss SetOverflow<TCodeCss>(this TCodeCss codeCss, string overflow)
            where TCodeCss : CodeCss
        {
            codeCss.Overflow = overflow;

            return codeCss;
        }
    }
}
