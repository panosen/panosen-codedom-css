namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// flex
        /// </summary>
        public string Flex { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set flex
        /// </summary>
        public static TCodeCss SetFlex<TCodeCss>(this TCodeCss codeCss, string flex)
            where TCodeCss : CodeCss
        {
            codeCss.Flex = flex;

            return codeCss;
        }
    }
}
