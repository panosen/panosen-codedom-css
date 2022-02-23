namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// order
        /// </summary>
        public string Order { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set order
        /// </summary>
        public static TCodeCss SetOrder<TCodeCss>(this TCodeCss codeCss, string order)
            where TCodeCss : CodeCss
        {
            codeCss.Order = order;

            return codeCss;
        }
    }
}
