namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string BorderImageSource = "border-image-source";

        private static void GenerateBorderImageSource(CodeWriter codeWriter, string borderImageSource, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, BorderImageSource, borderImageSource, options);
        }
    }
}
