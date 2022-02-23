namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// font
        /// </summary>
        public string Font { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set font
        /// </summary>
        public static TCodeCss SetFont<TCodeCss>(this TCodeCss codeCss, string font)
            where TCodeCss : CodeCss
        {
            codeCss.Font = font;

            return codeCss;
        }
    }
}
