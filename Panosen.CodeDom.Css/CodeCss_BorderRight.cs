namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// border-right
        /// </summary>
        public string BorderRight { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set border-right
        /// </summary>
        public static TCodeCss SetBorderRight<TCodeCss>(this TCodeCss codeCss, string borderRight)
            where TCodeCss : CodeCss
        {
            codeCss.BorderRight = borderRight;

            return codeCss;
        }
    }
}
