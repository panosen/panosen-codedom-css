namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// border-image-outset
        /// </summary>
        public string BorderImageOutset { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set border-image-outset
        /// </summary>
        public static TCodeCss SetBorderImageOutset<TCodeCss>(this TCodeCss codeCss, string borderImageOutset)
            where TCodeCss : CodeCss
        {
            codeCss.BorderImageOutset = borderImageOutset;

            return codeCss;
        }
    }
}
