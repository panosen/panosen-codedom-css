namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// text-combine-upright
        /// </summary>
        public string TextCombineUpright { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set text-combine-upright
        /// </summary>
        public static TCodeCss SetTextCombineUpright<TCodeCss>(this TCodeCss codeCss, string textCombineUpright)
            where TCodeCss : CodeCss
        {
            codeCss.TextCombineUpright = textCombineUpright;

            return codeCss;
        }
    }
}
