namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// background-attachment
        /// </summary>
        public string BackgroundAttachment { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set background-attachment
        /// </summary>
        public static TCodeCss SetBackgroundAttachment<TCodeCss>(this TCodeCss codeCss, string backgroundAttachment)
            where TCodeCss : CodeCss
        {
            codeCss.BackgroundAttachment = backgroundAttachment;

            return codeCss;
        }
    }
}
