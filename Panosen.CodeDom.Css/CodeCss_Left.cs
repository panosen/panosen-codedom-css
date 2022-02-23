namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// left
        /// </summary>
        public string Left { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set left
        /// </summary>
        public static TCodeCss SetLeft<TCodeCss>(this TCodeCss codeCss, string left)
            where TCodeCss : CodeCss
        {
            codeCss.Left = left;

            return codeCss;
        }
    }
}
