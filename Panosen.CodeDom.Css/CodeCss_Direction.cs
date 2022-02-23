namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// direction
        /// </summary>
        public string Direction { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set direction
        /// </summary>
        public static TCodeCss SetDirection<TCodeCss>(this TCodeCss codeCss, string direction)
            where TCodeCss : CodeCss
        {
            codeCss.Direction = direction;

            return codeCss;
        }
    }
}
