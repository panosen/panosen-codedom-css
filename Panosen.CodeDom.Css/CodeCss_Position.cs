namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// position
        /// </summary>
        public string Position { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set position
        /// </summary>
        public static TCodeCss SetPosition<TCodeCss>(this TCodeCss codeCss, string position)
            where TCodeCss : CodeCss
        {
            codeCss.Position = position;

            return codeCss;
        }
    }
}
