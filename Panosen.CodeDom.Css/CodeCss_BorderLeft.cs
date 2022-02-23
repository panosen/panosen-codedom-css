namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// border-left
        /// </summary>
        public string BorderLeft { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set border-left
        /// </summary>
        public static TCodeCss SetBorderLeft<TCodeCss>(this TCodeCss codeCss, string borderLeft)
            where TCodeCss : CodeCss
        {
            codeCss.BorderLeft = borderLeft;

            return codeCss;
        }
    }
}
