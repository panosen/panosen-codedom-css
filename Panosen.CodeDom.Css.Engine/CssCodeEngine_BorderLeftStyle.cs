namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string BorderLeftStyle = "border-left-style";

        private static void GenerateBorderLeftStyle(CodeWriter codeWriter, string borderLeftStyle, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, BorderLeftStyle, borderLeftStyle, options);
        }
    }
}
