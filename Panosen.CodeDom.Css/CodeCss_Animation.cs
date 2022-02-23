namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// animation
        /// </summary>
        public string Animation { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set animation
        /// </summary>
        public static TCodeCss SetAnimation<TCodeCss>(this TCodeCss codeCss, string animation)
            where TCodeCss : CodeCss
        {
            codeCss.Animation = animation;

            return codeCss;
        }
    }
}
