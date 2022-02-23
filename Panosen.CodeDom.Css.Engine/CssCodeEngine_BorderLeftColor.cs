namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string BorderLeftColor = "border-left-color";

        private static void GenerateBorderLeftColor(CodeWriter codeWriter, string borderLeftColor, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, BorderLeftColor, borderLeftColor, options);
        }
    }
}
