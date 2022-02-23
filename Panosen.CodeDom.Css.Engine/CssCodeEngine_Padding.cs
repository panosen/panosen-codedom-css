namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string Padding = "padding";

        private static void GeneratePadding(CodeWriter codeWriter, string padding, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, Padding, padding, options);
        }
    }
}
