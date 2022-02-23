namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// border-top-left-radius
        /// </summary>
        public string BorderTopLeftRadius { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set border-top-left-radius
        /// </summary>
        public static TCodeCss SetBorderTopLeftRadius<TCodeCss>(this TCodeCss codeCss, string borderTopLeftRadius)
            where TCodeCss : CodeCss
        {
            codeCss.BorderTopLeftRadius = borderTopLeftRadius;

            return codeCss;
        }
    }
}
