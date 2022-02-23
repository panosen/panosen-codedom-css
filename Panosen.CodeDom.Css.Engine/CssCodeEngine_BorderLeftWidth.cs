namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string BorderLeftWidth = "border-left-width";

        private static void GenerateBorderLeftWidth(CodeWriter codeWriter, string borderLeftWidth, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, BorderLeftWidth, borderLeftWidth, options);
        }
    }
}
