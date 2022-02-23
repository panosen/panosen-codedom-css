namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string BorderTopLeftRadius = "border-top-left-radius";

        private static void GenerateBorderTopLeftRadius(CodeWriter codeWriter, string borderTopLeftRadius, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, BorderTopLeftRadius, borderTopLeftRadius, options);
        }
    }
}
