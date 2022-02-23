namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string BorderImage = "border-image";

        private static void GenerateBorderImage(CodeWriter codeWriter, string borderImage, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, BorderImage, borderImage, options);
        }
    }
}
