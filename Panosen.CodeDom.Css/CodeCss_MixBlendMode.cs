namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// mix-blend-mode
        /// </summary>
        public string MixBlendMode { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set mix-blend-mode
        /// </summary>
        public static TCodeCss SetMixBlendMode<TCodeCss>(this TCodeCss codeCss, string mixBlendMode)
            where TCodeCss : CodeCss
        {
            codeCss.MixBlendMode = mixBlendMode;

            return codeCss;
        }
    }
}
