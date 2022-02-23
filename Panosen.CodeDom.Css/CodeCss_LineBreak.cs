namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// line-break
        /// </summary>
        public string LineBreak { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set line-break
        /// </summary>
        public static TCodeCss SetLineBreak<TCodeCss>(this TCodeCss codeCss, string lineBreak)
            where TCodeCss : CodeCss
        {
            codeCss.LineBreak = lineBreak;

            return codeCss;
        }
    }
}
