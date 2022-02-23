namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string BorderLeft = "border-left";

        private static void GenerateBorderLeft(CodeWriter codeWriter, string borderLeft, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, BorderLeft, borderLeft, options);
        }
    }
}
