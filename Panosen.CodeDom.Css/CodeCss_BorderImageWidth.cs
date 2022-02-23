namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// border-image-width
        /// </summary>
        public string BorderImageWidth { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set border-image-width
        /// </summary>
        public static TCodeCss SetBorderImageWidth<TCodeCss>(this TCodeCss codeCss, string borderImageWidth)
            where TCodeCss : CodeCss
        {
            codeCss.BorderImageWidth = borderImageWidth;

            return codeCss;
        }
    }
}
