namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// max-width
        /// </summary>
        public string MaxWidth { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set max-width
        /// </summary>
        public static TCodeCss SetMaxWidth<TCodeCss>(this TCodeCss codeCss, string maxWidth)
            where TCodeCss : CodeCss
        {
            codeCss.MaxWidth = maxWidth;

            return codeCss;
        }
    }
}
