namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// animation-duration
        /// </summary>
        public string AnimationDuration { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set animation-duration
        /// </summary>
        public static TCodeCss SetAnimationDuration<TCodeCss>(this TCodeCss codeCss, string animationDuration)
            where TCodeCss : CodeCss
        {
            codeCss.AnimationDuration = animationDuration;

            return codeCss;
        }
    }
}
