namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// flex-basis
        /// </summary>
        public string FlexBasis { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set flex-basis
        /// </summary>
        public static TCodeCss SetFlexBasis<TCodeCss>(this TCodeCss codeCss, string flexBasis)
            where TCodeCss : CodeCss
        {
            codeCss.FlexBasis = flexBasis;

            return codeCss;
        }
    }
}
