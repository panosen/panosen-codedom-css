namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// clip
        /// </summary>
        public string Clip { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set clip
        /// </summary>
        public static TCodeCss SetClip<TCodeCss>(this TCodeCss codeCss, string clip)
            where TCodeCss : CodeCss
        {
            codeCss.Clip = clip;

            return codeCss;
        }
    }
}
