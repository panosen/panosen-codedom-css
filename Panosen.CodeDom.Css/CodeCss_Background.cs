namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// background
        /// </summary>
        public string Background { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set background
        /// </summary>
        public static TCodeCss SetBackground<TCodeCss>(this TCodeCss codeCss, string background)
            where TCodeCss : CodeCss
        {
            codeCss.Background = background;

            return codeCss;
        }
    }
}
