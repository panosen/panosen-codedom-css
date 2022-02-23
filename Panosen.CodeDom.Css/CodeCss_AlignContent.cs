namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// align-content
        /// </summary>
        public string AlignContent { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set align-content
        /// </summary>
        public static TCodeCss SetAlignContent<TCodeCss>(this TCodeCss codeCss, string alignContent)
            where TCodeCss : CodeCss
        {
            codeCss.AlignContent = alignContent;

            return codeCss;
        }
    }
}
