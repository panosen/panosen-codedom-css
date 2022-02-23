namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string BorderBottomWidth = "border-bottom-width";

        private static void GenerateBorderBottomWidth(CodeWriter codeWriter, string borderBottomWidth, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, BorderBottomWidth, borderBottomWidth, options);
        }
    }
}
