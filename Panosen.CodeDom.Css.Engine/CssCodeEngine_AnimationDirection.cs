namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string AnimationDirection = "animation-direction";

        private static void GenerateAnimationDirection(CodeWriter codeWriter, string animationDirection, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, AnimationDirection, animationDirection, options);
        }
    }
}
