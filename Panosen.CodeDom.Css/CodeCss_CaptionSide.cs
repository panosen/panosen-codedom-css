namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// caption-side
        /// </summary>
        public string CaptionSide { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set caption-side
        /// </summary>
        public static TCodeCss SetCaptionSide<TCodeCss>(this TCodeCss codeCss, string captionSide)
            where TCodeCss : CodeCss
        {
            codeCss.CaptionSide = captionSide;

            return codeCss;
        }
    }
}
