namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// border-radius
        /// </summary>
        public string BorderRadius { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set border-radius
        /// </summary>
        public static TCodeCss SetBorderRadius<TCodeCss>(this TCodeCss codeCss, string borderRadius)
            where TCodeCss : CodeCss
        {
            codeCss.BorderRadius = borderRadius;

            return codeCss;
        }
    }
}
