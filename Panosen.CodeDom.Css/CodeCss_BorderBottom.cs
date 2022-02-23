namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// border-bottom
        /// </summary>
        public string BorderBottom { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set border-bottom
        /// </summary>
        public static TCodeCss SetBorderBottom<TCodeCss>(this TCodeCss codeCss, string borderBottom)
            where TCodeCss : CodeCss
        {
            codeCss.BorderBottom = borderBottom;

            return codeCss;
        }
    }
}
