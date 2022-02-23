namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// bottom
        /// </summary>
        public string Bottom { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set bottom
        /// </summary>
        public static TCodeCss SetBottom<TCodeCss>(this TCodeCss codeCss, string bottom)
            where TCodeCss : CodeCss
        {
            codeCss.Bottom = bottom;

            return codeCss;
        }
    }
}
