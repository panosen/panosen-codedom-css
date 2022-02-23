namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// all
        /// </summary>
        public string All { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set all
        /// </summary>
        public static TCodeCss SetAll<TCodeCss>(this TCodeCss codeCss, string all)
            where TCodeCss : CodeCss
        {
            codeCss.All = all;

            return codeCss;
        }
    }
}
