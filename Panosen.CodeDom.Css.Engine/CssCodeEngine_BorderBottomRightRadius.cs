namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string BorderBottomRightRadius = "border-bottom-right-radius";

        private static void GenerateBorderBottomRightRadius(CodeWriter codeWriter, string borderBottomRightRadius, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, BorderBottomRightRadius, borderBottomRightRadius, options);
        }
    }
}
