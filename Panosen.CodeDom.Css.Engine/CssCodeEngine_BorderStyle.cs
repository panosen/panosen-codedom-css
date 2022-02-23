namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string BorderStyle = "border-style";

        private static void GenerateBorderStyle(CodeWriter codeWriter, string borderStyle, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, BorderStyle, borderStyle, options);
        }
    }
}
