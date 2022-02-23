namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// animation-timing-function
        /// </summary>
        public string AnimationTimingFunction { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set animation-timing-function
        /// </summary>
        public static TCodeCss SetAnimationTimingFunction<TCodeCss>(this TCodeCss codeCss, string animationTimingFunction)
            where TCodeCss : CodeCss
        {
            codeCss.AnimationTimingFunction = animationTimingFunction;

            return codeCss;
        }
    }
}
