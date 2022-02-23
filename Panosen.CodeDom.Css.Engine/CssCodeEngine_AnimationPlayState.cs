namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string AnimationPlayState = "animation-play-state";

        private static void GenerateAnimationPlayState(CodeWriter codeWriter, string animationPlayState, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, AnimationPlayState, animationPlayState, options);
        }
    }
}
