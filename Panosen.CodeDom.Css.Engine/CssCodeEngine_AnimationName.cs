namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string AnimationName = "animation-name";

        private static void GenerateAnimationName(CodeWriter codeWriter, string animationName, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, AnimationName, animationName, options);
        }
    }
}
