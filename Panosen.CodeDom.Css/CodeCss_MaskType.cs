namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// mask-type
        /// </summary>
        public string MaskType { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set mask-type
        /// </summary>
        public static TCodeCss SetMaskType<TCodeCss>(this TCodeCss codeCss, string maskType)
            where TCodeCss : CodeCss
        {
            codeCss.MaskType = maskType;

            return codeCss;
        }
    }
}
