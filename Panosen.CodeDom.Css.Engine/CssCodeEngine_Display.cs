namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string Display = "display";

        private static void GenerateDisplay(CodeWriter codeWriter, string display, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, Display, display, options);
        }
    }
}
