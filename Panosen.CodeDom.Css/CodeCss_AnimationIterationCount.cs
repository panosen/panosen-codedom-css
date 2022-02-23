namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// animation-iteration-count
        /// </summary>
        public string AnimationIterationCount { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set animation-iteration-count
        /// </summary>
        public static TCodeCss SetAnimationIterationCount<TCodeCss>(this TCodeCss codeCss, string animationIterationCount)
            where TCodeCss : CodeCss
        {
            codeCss.AnimationIterationCount = animationIterationCount;

            return codeCss;
        }
    }
}
