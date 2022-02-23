namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// border-image
        /// </summary>
        public string BorderImage { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set border-image
        /// </summary>
        public static TCodeCss SetBorderImage<TCodeCss>(this TCodeCss codeCss, string borderImage)
            where TCodeCss : CodeCss
        {
            codeCss.BorderImage = borderImage;

            return codeCss;
        }
    }
}
