namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string AnimationIterationCount = "animation-iteration-count";

        private static void GenerateAnimationIterationCount(CodeWriter codeWriter, string animationIterationCount, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, AnimationIterationCount, animationIterationCount, options);
        }
    }
}
