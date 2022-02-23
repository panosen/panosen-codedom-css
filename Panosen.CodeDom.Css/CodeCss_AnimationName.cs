namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// animation-name
        /// </summary>
        public string AnimationName { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set animation-name
        /// </summary>
        public static TCodeCss SetAnimationName<TCodeCss>(this TCodeCss codeCss, string animationName)
            where TCodeCss : CodeCss
        {
            codeCss.AnimationName = animationName;

            return codeCss;
        }
    }
}
