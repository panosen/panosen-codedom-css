namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// @charset
        /// </summary>
        public string Charset { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set @charset
        /// </summary>
        public static TCodeCss SetCharset<TCodeCss>(this TCodeCss codeCss, string charset)
            where TCodeCss : CodeCss
        {
            codeCss.Charset = charset;

            return codeCss;
        }
    }
}
