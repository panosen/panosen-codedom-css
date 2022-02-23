namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// background-repeat
        /// </summary>
        public string BackgroundRepeat { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set background-repeat
        /// </summary>
        public static TCodeCss SetBackgroundRepeat<TCodeCss>(this TCodeCss codeCss, string backgroundRepeat)
            where TCodeCss : CodeCss
        {
            codeCss.BackgroundRepeat = backgroundRepeat;

            return codeCss;
        }
    }
}
