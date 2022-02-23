namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string AnimationDelay = "animation-delay";

        private static void GenerateAnimationDelay(CodeWriter codeWriter, string animationDelay, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, AnimationDelay, animationDelay, options);
        }
    }
}
