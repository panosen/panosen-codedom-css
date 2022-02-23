namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// image-rendering
        /// </summary>
        public string ImageRendering { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set image-rendering
        /// </summary>
        public static TCodeCss SetImageRendering<TCodeCss>(this TCodeCss codeCss, string imageRendering)
            where TCodeCss : CodeCss
        {
            codeCss.ImageRendering = imageRendering;

            return codeCss;
        }
    }
}
