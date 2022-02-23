namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// height
        /// </summary>
        public string Height { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set height
        /// </summary>
        public static TCodeCss SetHeight<TCodeCss>(this TCodeCss codeCss, string height)
            where TCodeCss : CodeCss
        {
            codeCss.Height = height;

            return codeCss;
        }
    }
}
