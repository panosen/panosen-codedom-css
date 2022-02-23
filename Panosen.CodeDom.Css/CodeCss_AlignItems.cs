namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// align-items
        /// </summary>
        public string AlignItems { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set align-items
        /// </summary>
        public static TCodeCss SetAlignItems<TCodeCss>(this TCodeCss codeCss, string alignItems)
            where TCodeCss : CodeCss
        {
            codeCss.AlignItems = alignItems;

            return codeCss;
        }
    }
}
