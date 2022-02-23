namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// padding-top
        /// </summary>
        public string PaddingTop { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set padding-top
        /// </summary>
        public static TCodeCss SetPaddingTop<TCodeCss>(this TCodeCss codeCss, string paddingTop)
            where TCodeCss : CodeCss
        {
            codeCss.PaddingTop = paddingTop;

            return codeCss;
        }
    }
}
