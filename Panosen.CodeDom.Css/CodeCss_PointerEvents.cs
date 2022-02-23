namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// pointer-events
        /// </summary>
        public string PointerEvents { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set pointer-events
        /// </summary>
        public static TCodeCss SetPointerEvents<TCodeCss>(this TCodeCss codeCss, string pointerEvents)
            where TCodeCss : CodeCss
        {
            codeCss.PointerEvents = pointerEvents;

            return codeCss;
        }
    }
}
