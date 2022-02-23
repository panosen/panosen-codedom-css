namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// animation-direction
        /// </summary>
        public string AnimationDirection { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set animation-direction
        /// </summary>
        public static TCodeCss SetAnimationDirection<TCodeCss>(this TCodeCss codeCss, string animationDirection)
            where TCodeCss : CodeCss
        {
            codeCss.AnimationDirection = animationDirection;

            return codeCss;
        }
    }
}
