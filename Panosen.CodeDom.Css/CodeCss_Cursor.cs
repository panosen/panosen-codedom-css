namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// cursor
        /// </summary>
        public string Cursor { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set cursor
        /// </summary>
        public static TCodeCss SetCursor<TCodeCss>(this TCodeCss codeCss, string cursor)
            where TCodeCss : CodeCss
        {
            codeCss.Cursor = cursor;

            return codeCss;
        }
    }
}
