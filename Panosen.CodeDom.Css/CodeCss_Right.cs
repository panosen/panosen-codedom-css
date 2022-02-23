namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// right
        /// </summary>
        public string Right { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set right
        /// </summary>
        public static TCodeCss SetRight<TCodeCss>(this TCodeCss codeCss, string right)
            where TCodeCss : CodeCss
        {
            codeCss.Right = right;

            return codeCss;
        }
    }
}
