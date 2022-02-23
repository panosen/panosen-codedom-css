namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// clear
        /// </summary>
        public string Clear { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set clear
        /// </summary>
        public static TCodeCss SetClear<TCodeCss>(this TCodeCss codeCss, string clear)
            where TCodeCss : CodeCss
        {
            codeCss.Clear = clear;

            return codeCss;
        }
    }
}
