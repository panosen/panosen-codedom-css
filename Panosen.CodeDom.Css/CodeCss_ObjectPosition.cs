namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// object-position
        /// </summary>
        public string ObjectPosition { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set object-position
        /// </summary>
        public static TCodeCss SetObjectPosition<TCodeCss>(this TCodeCss codeCss, string objectPosition)
            where TCodeCss : CodeCss
        {
            codeCss.ObjectPosition = objectPosition;

            return codeCss;
        }
    }
}
