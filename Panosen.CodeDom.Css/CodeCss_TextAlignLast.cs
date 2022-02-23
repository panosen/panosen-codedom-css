namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// text-align-last
        /// </summary>
        public string TextAlignLast { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set text-align-last
        /// </summary>
        public static TCodeCss SetTextAlignLast<TCodeCss>(this TCodeCss codeCss, string textAlignLast)
            where TCodeCss : CodeCss
        {
            codeCss.TextAlignLast = textAlignLast;

            return codeCss;
        }
    }
}
