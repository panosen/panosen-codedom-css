namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// color
        /// </summary>
        public string Color { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set color
        /// </summary>
        public static TCodeCss SetColor<TCodeCss>(this TCodeCss codeCss, string color)
            where TCodeCss : CodeCss
        {
            codeCss.Color = color;

            return codeCss;
        }
    }
}
