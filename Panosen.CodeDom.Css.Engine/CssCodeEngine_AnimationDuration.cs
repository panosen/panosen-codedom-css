namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string AnimationDuration = "animation-duration";

        private static void GenerateAnimationDuration(CodeWriter codeWriter, string animationDuration, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, AnimationDuration, animationDuration, options);
        }
    }
}
