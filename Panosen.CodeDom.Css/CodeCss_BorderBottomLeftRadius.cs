namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// border-bottom-left-radius
        /// </summary>
        public string BorderBottomLeftRadius { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set border-bottom-left-radius
        /// </summary>
        public static TCodeCss SetBorderBottomLeftRadius<TCodeCss>(this TCodeCss codeCss, string borderBottomLeftRadius)
            where TCodeCss : CodeCss
        {
            codeCss.BorderBottomLeftRadius = borderBottomLeftRadius;

            return codeCss;
        }
    }
}
