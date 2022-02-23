namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// animation-play-state
        /// </summary>
        public string AnimationPlayState { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set animation-play-state
        /// </summary>
        public static TCodeCss SetAnimationPlayState<TCodeCss>(this TCodeCss codeCss, string animationPlayState)
            where TCodeCss : CodeCss
        {
            codeCss.AnimationPlayState = animationPlayState;

            return codeCss;
        }
    }
}
