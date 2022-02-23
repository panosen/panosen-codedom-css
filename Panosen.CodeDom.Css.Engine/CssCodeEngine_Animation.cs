namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string Animation = "animation";

        private static void GenerateAnimation(CodeWriter codeWriter, string animation, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, Animation, animation, options);
        }
    }
}
