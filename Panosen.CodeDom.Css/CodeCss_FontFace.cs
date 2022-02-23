namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// @font-face
        /// </summary>
        public string FontFace { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set @font-face
        /// </summary>
        public static TCodeCss SetFontFace<TCodeCss>(this TCodeCss codeCss, string fontFace)
            where TCodeCss : CodeCss
        {
            codeCss.FontFace = fontFace;

            return codeCss;
        }
    }
}
