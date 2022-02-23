namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// flex-flow
        /// </summary>
        public string FlexFlow { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set flex-flow
        /// </summary>
        public static TCodeCss SetFlexFlow<TCodeCss>(this TCodeCss codeCss, string flexFlow)
            where TCodeCss : CodeCss
        {
            codeCss.FlexFlow = flexFlow;

            return codeCss;
        }
    }
}
