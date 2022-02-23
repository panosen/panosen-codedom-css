namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// border-image-source
        /// </summary>
        public string BorderImageSource { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set border-image-source
        /// </summary>
        public static TCodeCss SetBorderImageSource<TCodeCss>(this TCodeCss codeCss, string borderImageSource)
            where TCodeCss : CodeCss
        {
            codeCss.BorderImageSource = borderImageSource;

            return codeCss;
        }
    }
}
