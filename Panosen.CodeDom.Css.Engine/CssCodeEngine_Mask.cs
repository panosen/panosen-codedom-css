namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string Mask = "mask";

        private static void GenerateMask(CodeWriter codeWriter, string mask, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, Mask, mask, options);
        }
    }
}
