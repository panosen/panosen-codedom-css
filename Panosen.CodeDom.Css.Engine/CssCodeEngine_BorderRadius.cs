namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string BorderRadius = "border-radius";

        private static void GenerateBorderRadius(CodeWriter codeWriter, string borderRadius, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, BorderRadius, borderRadius, options);
        }
    }
}
