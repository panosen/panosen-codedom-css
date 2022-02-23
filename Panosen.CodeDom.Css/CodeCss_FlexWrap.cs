namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// flex-wrap
        /// </summary>
        public string FlexWrap { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set flex-wrap
        /// </summary>
        public static TCodeCss SetFlexWrap<TCodeCss>(this TCodeCss codeCss, string flexWrap)
            where TCodeCss : CodeCss
        {
            codeCss.FlexWrap = flexWrap;

            return codeCss;
        }
    }
}
