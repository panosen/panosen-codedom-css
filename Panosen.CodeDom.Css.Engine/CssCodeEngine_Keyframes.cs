namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string Keyframes = "@keyframes";

        private static void GenerateKeyframes(CodeWriter codeWriter, string keyframes, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, Keyframes, keyframes, options);
        }
    }
}
