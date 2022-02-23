namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// flex-grow
        /// </summary>
        public string FlexGrow { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set flex-grow
        /// </summary>
        public static TCodeCss SetFlexGrow<TCodeCss>(this TCodeCss codeCss, string flexGrow)
            where TCodeCss : CodeCss
        {
            codeCss.FlexGrow = flexGrow;

            return codeCss;
        }
    }
}
