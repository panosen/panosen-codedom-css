namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// border-image-repeat
        /// </summary>
        public string BorderImageRepeat { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set border-image-repeat
        /// </summary>
        public static TCodeCss SetBorderImageRepeat<TCodeCss>(this TCodeCss codeCss, string borderImageRepeat)
            where TCodeCss : CodeCss
        {
            codeCss.BorderImageRepeat = borderImageRepeat;

            return codeCss;
        }
    }
}
