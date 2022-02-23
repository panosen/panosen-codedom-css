namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// animation-fill-mode
        /// </summary>
        public string AnimationFillMode { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set animation-fill-mode
        /// </summary>
        public static TCodeCss SetAnimationFillMode<TCodeCss>(this TCodeCss codeCss, string animationFillMode)
            where TCodeCss : CodeCss
        {
            codeCss.AnimationFillMode = animationFillMode;

            return codeCss;
        }
    }
}
