namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string BorderColor = "border-color";

        private static void GenerateBorderColor(CodeWriter codeWriter, string borderColor, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, BorderColor, borderColor, options);
        }
    }
}
