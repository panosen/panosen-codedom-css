namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// row-gap
        /// </summary>
        public string RowGap { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set row-gap
        /// </summary>
        public static TCodeCss SetRowGap<TCodeCss>(this TCodeCss codeCss, string rowGap)
            where TCodeCss : CodeCss
        {
            codeCss.RowGap = rowGap;

            return codeCss;
        }
    }
}
