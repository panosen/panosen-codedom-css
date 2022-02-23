namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string MixBlendMode = "mix-blend-mode";

        private static void GenerateMixBlendMode(CodeWriter codeWriter, string mixBlendMode, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, MixBlendMode, mixBlendMode, options);
        }
    }
}
