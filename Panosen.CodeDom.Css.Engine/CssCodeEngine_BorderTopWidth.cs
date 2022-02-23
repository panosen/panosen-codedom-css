namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string BorderTopWidth = "border-top-width";

        private static void GenerateBorderTopWidth(CodeWriter codeWriter, string borderTopWidth, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, BorderTopWidth, borderTopWidth, options);
        }
    }
}
