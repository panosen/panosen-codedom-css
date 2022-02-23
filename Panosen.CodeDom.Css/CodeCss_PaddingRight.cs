namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// padding-right
        /// </summary>
        public string PaddingRight { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set padding-right
        /// </summary>
        public static TCodeCss SetPaddingRight<TCodeCss>(this TCodeCss codeCss, string paddingRight)
            where TCodeCss : CodeCss
        {
            codeCss.PaddingRight = paddingRight;

            return codeCss;
        }
    }
}
