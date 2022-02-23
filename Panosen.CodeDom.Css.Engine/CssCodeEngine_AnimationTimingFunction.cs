namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string AnimationTimingFunction = "animation-timing-function";

        private static void GenerateAnimationTimingFunction(CodeWriter codeWriter, string animationTimingFunction, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, AnimationTimingFunction, animationTimingFunction, options);
        }
    }
}
