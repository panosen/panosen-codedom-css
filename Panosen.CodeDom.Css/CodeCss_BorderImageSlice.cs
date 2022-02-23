namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// border-image-slice
        /// </summary>
        public string BorderImageSlice { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set border-image-slice
        /// </summary>
        public static TCodeCss SetBorderImageSlice<TCodeCss>(this TCodeCss codeCss, string borderImageSlice)
            where TCodeCss : CodeCss
        {
            codeCss.BorderImageSlice = borderImageSlice;

            return codeCss;
        }
    }
}
