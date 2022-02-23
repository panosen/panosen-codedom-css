namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string BorderRight = "border-right";

        private static void GenerateBorderRight(CodeWriter codeWriter, string borderRight, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, BorderRight, borderRight, options);
        }
    }
}
