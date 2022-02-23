namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// border-bottom-right-radius
        /// </summary>
        public string BorderBottomRightRadius { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set border-bottom-right-radius
        /// </summary>
        public static TCodeCss SetBorderBottomRightRadius<TCodeCss>(this TCodeCss codeCss, string borderBottomRightRadius)
            where TCodeCss : CodeCss
        {
            codeCss.BorderBottomRightRadius = borderBottomRightRadius;

            return codeCss;
        }
    }
}
