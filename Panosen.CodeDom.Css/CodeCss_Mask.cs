namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// mask
        /// </summary>
        public string Mask { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set mask
        /// </summary>
        public static TCodeCss SetMask<TCodeCss>(this TCodeCss codeCss, string mask)
            where TCodeCss : CodeCss
        {
            codeCss.Mask = mask;

            return codeCss;
        }
    }
}
