namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// background-image
        /// </summary>
        public string BackgroundImage { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set background-image
        /// </summary>
        public static TCodeCss SetBackgroundImage<TCodeCss>(this TCodeCss codeCss, string backgroundImage)
            where TCodeCss : CodeCss
        {
            codeCss.BackgroundImage = backgroundImage;

            return codeCss;
        }
    }
}
