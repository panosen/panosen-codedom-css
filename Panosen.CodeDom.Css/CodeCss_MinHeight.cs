namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// min-height
        /// </summary>
        public string MinHeight { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set min-height
        /// </summary>
        public static TCodeCss SetMinHeight<TCodeCss>(this TCodeCss codeCss, string minHeight)
            where TCodeCss : CodeCss
        {
            codeCss.MinHeight = minHeight;

            return codeCss;
        }
    }
}
