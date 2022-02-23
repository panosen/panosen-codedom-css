namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// border-top-right-radius
        /// </summary>
        public string BorderTopRightRadius { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set border-top-right-radius
        /// </summary>
        public static TCodeCss SetBorderTopRightRadius<TCodeCss>(this TCodeCss codeCss, string borderTopRightRadius)
            where TCodeCss : CodeCss
        {
            codeCss.BorderTopRightRadius = borderTopRightRadius;

            return codeCss;
        }
    }
}
