namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string Clip = "clip";

        private static void GenerateClip(CodeWriter codeWriter, string clip, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, Clip, clip, options);
        }
    }
}
