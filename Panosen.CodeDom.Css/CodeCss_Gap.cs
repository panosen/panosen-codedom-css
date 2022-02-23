namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// gap
        /// </summary>
        public string Gap { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set gap
        /// </summary>
        public static TCodeCss SetGap<TCodeCss>(this TCodeCss codeCss, string gap)
            where TCodeCss : CodeCss
        {
            codeCss.Gap = gap;

            return codeCss;
        }
    }
}
