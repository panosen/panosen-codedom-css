namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string Height = "height";

        private static void GenerateHeight(CodeWriter codeWriter, string height, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, Height, height, options);
        }
    }
}
