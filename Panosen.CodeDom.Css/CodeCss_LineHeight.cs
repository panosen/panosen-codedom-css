namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// line-height
        /// </summary>
        public string LineHeight { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set line-height
        /// </summary>
        public static TCodeCss SetLineHeight<TCodeCss>(this TCodeCss codeCss, string lineHeight)
            where TCodeCss : CodeCss
        {
            codeCss.LineHeight = lineHeight;

            return codeCss;
        }
    }
}
