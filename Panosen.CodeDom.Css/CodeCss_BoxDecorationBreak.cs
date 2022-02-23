namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// box-decoration-break
        /// </summary>
        public string BoxDecorationBreak { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set box-decoration-break
        /// </summary>
        public static TCodeCss SetBoxDecorationBreak<TCodeCss>(this TCodeCss codeCss, string boxDecorationBreak)
            where TCodeCss : CodeCss
        {
            codeCss.BoxDecorationBreak = boxDecorationBreak;

            return codeCss;
        }
    }
}
