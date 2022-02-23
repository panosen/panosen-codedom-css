namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// animation-delay
        /// </summary>
        public string AnimationDelay { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set animation-delay
        /// </summary>
        public static TCodeCss SetAnimationDelay<TCodeCss>(this TCodeCss codeCss, string animationDelay)
            where TCodeCss : CodeCss
        {
            codeCss.AnimationDelay = animationDelay;

            return codeCss;
        }
    }
}
