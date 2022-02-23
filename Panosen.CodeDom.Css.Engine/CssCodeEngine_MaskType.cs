namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string MaskType = "mask-type";

        private static void GenerateMaskType(CodeWriter codeWriter, string maskType, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, MaskType, maskType, options);
        }
    }
}
