namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// z-index
        /// </summary>
        public string ZIndex { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set z-index
        /// </summary>
        public static TCodeCss SetZIndex<TCodeCss>(this TCodeCss codeCss, string zindex)
            where TCodeCss : CodeCss
        {
            codeCss.ZIndex = zindex;

            return codeCss;
        }
    }
}
