namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// caret-color
        /// </summary>
        public string CaretColor { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set caret-color
        /// </summary>
        public static TCodeCss SetCaretColor<TCodeCss>(this TCodeCss codeCss, string caretColor)
            where TCodeCss : CodeCss
        {
            codeCss.CaretColor = caretColor;

            return codeCss;
        }
    }
}
