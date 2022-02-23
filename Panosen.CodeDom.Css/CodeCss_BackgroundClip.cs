namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// background-clip
        /// </summary>
        public string BackgroundClip { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set background-clip
        /// </summary>
        public static TCodeCss SetBackgroundClip<TCodeCss>(this TCodeCss codeCss, string backgroundClip)
            where TCodeCss : CodeCss
        {
            codeCss.BackgroundClip = backgroundClip;

            return codeCss;
        }
    }
}
