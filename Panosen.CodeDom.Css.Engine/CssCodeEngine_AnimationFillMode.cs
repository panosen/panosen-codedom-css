namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string AnimationFillMode = "animation-fill-mode";

        private static void GenerateAnimationFillMode(CodeWriter codeWriter, string animationFillMode, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, AnimationFillMode, animationFillMode, options);
        }
    }
}
