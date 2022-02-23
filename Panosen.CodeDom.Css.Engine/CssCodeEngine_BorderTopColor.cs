namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string BorderTopColor = "border-top-color";

        private static void GenerateBorderTopColor(CodeWriter codeWriter, string borderTopColor, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, BorderTopColor, borderTopColor, options);
        }
    }
}
