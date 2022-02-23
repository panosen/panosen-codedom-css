namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string BorderBottomColor = "border-bottom-color";

        private static void GenerateBorderBottomColor(CodeWriter codeWriter, string borderBottomColor, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, BorderBottomColor, borderBottomColor, options);
        }
    }
}
