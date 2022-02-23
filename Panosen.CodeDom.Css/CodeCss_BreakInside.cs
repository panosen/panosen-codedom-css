namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// break-inside
        /// </summary>
        public string BreakInside { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set break-inside
        /// </summary>
        public static TCodeCss SetBreakInside<TCodeCss>(this TCodeCss codeCss, string breakInside)
            where TCodeCss : CodeCss
        {
            codeCss.BreakInside = breakInside;

            return codeCss;
        }
    }
}
