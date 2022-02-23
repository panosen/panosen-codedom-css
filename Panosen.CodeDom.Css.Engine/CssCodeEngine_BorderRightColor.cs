namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string BorderRightColor = "border-right-color";

        private static void GenerateBorderRightColor(CodeWriter codeWriter, string borderRightColor, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, BorderRightColor, borderRightColor, options);
        }
    }
}
