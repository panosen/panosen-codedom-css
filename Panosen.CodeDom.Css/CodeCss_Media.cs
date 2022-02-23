namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// @media
        /// </summary>
        public string Media { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set @media
        /// </summary>
        public static TCodeCss SetMedia<TCodeCss>(this TCodeCss codeCss, string media)
            where TCodeCss : CodeCss
        {
            codeCss.Media = media;

            return codeCss;
        }
    }
}
