namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// border
        /// </summary>
        public string Border { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set border
        /// </summary>
        public static TCodeCss SetBorder<TCodeCss>(this TCodeCss codeCss, string border)
            where TCodeCss : CodeCss
        {
            codeCss.Border = border;

            return codeCss;
        }
    }
}
