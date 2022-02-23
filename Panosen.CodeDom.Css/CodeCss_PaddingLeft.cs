namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// padding-left
        /// </summary>
        public string PaddingLeft { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set padding-left
        /// </summary>
        public static TCodeCss SetPaddingLeft<TCodeCss>(this TCodeCss codeCss, string paddingLeft)
            where TCodeCss : CodeCss
        {
            codeCss.PaddingLeft = paddingLeft;

            return codeCss;
        }
    }
}
