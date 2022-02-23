namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// list-style-image
        /// </summary>
        public string ListStyleImage { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set list-style-image
        /// </summary>
        public static TCodeCss SetListStyleImage<TCodeCss>(this TCodeCss codeCss, string listStyleImage)
            where TCodeCss : CodeCss
        {
            codeCss.ListStyleImage = listStyleImage;

            return codeCss;
        }
    }
}
