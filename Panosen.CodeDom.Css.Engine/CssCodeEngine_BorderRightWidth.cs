namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string BorderRightWidth = "border-right-width";

        private static void GenerateBorderRightWidth(CodeWriter codeWriter, string borderRightWidth, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, BorderRightWidth, borderRightWidth, options);
        }
    }
}
