namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string ImageRendering = "image-rendering";

        private static void GenerateImageRendering(CodeWriter codeWriter, string imageRendering, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, ImageRendering, imageRendering, options);
        }
    }
}
