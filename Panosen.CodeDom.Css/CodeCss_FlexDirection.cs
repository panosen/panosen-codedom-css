namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// flex-direction
        /// </summary>
        public string FlexDirection { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set flex-direction
        /// </summary>
        public static TCodeCss SetFlexDirection<TCodeCss>(this TCodeCss codeCss, string flexDirection)
            where TCodeCss : CodeCss
        {
            codeCss.FlexDirection = flexDirection;

            return codeCss;
        }
    }
}
