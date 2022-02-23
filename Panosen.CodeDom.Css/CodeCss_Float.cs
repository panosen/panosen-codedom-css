namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// float
        /// </summary>
        public string Float { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set float
        /// </summary>
        public static TCodeCss SetFloat<TCodeCss>(this TCodeCss codeCss, string @float)
            where TCodeCss : CodeCss
        {
            codeCss.Float = @float;

            return codeCss;
        }
    }
}
