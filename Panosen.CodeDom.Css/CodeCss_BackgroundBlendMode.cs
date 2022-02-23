namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// background-blend-mode
        /// </summary>
        public string BackgroundBlendMode { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set background-blend-mode
        /// </summary>
        public static TCodeCss SetBackgroundBlendMode<TCodeCss>(this TCodeCss codeCss, string backgroundBlendMode)
            where TCodeCss : CodeCss
        {
            codeCss.BackgroundBlendMode = backgroundBlendMode;

            return codeCss;
        }
    }
}
