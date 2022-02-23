namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// @keyframes
        /// </summary>
        public string Keyframes { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set @keyframes
        /// </summary>
        public static TCodeCss SetKeyframes<TCodeCss>(this TCodeCss codeCss, string keyframes)
            where TCodeCss : CodeCss
        {
            codeCss.Keyframes = keyframes;

            return codeCss;
        }
    }
}
