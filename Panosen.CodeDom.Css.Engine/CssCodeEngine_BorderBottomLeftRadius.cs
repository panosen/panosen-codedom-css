namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string BorderBottomLeftRadius = "border-bottom-left-radius";

        private static void GenerateBorderBottomLeftRadius(CodeWriter codeWriter, string borderBottomLeftRadius, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, BorderBottomLeftRadius, borderBottomLeftRadius, options);
        }
    }
}
