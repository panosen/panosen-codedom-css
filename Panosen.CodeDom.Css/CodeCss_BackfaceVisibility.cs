namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// backface-visibility
        /// </summary>
        public string BackfaceVisibility { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set backface-visibility
        /// </summary>
        public static TCodeCss SetBackfaceVisibility<TCodeCss>(this TCodeCss codeCss, string backfaceVisibility)
            where TCodeCss : CodeCss
        {
            codeCss.BackfaceVisibility = backfaceVisibility;

            return codeCss;
        }
    }
}
