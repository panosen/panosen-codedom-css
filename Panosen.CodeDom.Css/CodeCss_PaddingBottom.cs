namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// padding-bottom
        /// </summary>
        public string PaddingBottom { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set padding-bottom
        /// </summary>
        public static TCodeCss SetPaddingBottom<TCodeCss>(this TCodeCss codeCss, string paddingBottom)
            where TCodeCss : CodeCss
        {
            codeCss.PaddingBottom = paddingBottom;

            return codeCss;
        }
    }
}
