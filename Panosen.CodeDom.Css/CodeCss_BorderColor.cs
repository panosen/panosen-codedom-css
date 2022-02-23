namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// border-color
        /// </summary>
        public string BorderColor { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set border-color
        /// </summary>
        public static TCodeCss SetBorderColor<TCodeCss>(this TCodeCss codeCss, string borderColor)
            where TCodeCss : CodeCss
        {
            codeCss.BorderColor = borderColor;

            return codeCss;
        }
    }
}
