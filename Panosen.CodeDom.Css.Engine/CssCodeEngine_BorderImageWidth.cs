namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string BorderImageWidth = "border-image-width";

        private static void GenerateBorderImageWidth(CodeWriter codeWriter, string borderImageWidth, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, BorderImageWidth, borderImageWidth, options);
        }
    }
}
