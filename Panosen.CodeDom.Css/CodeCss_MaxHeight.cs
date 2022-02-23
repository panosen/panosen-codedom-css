namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// max-height
        /// </summary>
        public string MaxHeight { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set max-height
        /// </summary>
        public static TCodeCss SetMaxHeight<TCodeCss>(this TCodeCss codeCss, string maxHeight)
            where TCodeCss : CodeCss
        {
            codeCss.MaxHeight = maxHeight;

            return codeCss;
        }
    }
}
