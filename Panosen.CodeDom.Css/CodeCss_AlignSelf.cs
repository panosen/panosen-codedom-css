namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// align-self
        /// </summary>
        public string AlignSelf { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set align-self
        /// </summary>
        public static TCodeCss SetAlignSelf<TCodeCss>(this TCodeCss codeCss, string alignSelf)
            where TCodeCss : CodeCss
        {
            codeCss.AlignSelf = alignSelf;

            return codeCss;
        }
    }
}
