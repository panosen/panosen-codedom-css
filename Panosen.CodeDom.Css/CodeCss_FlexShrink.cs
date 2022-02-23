namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// flex-shrink
        /// </summary>
        public string FlexShrink { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set flex-shrink
        /// </summary>
        public static TCodeCss SetFlexShrink<TCodeCss>(this TCodeCss codeCss, string flexShrink)
            where TCodeCss : CodeCss
        {
            codeCss.FlexShrink = flexShrink;

            return codeCss;
        }
    }
}
