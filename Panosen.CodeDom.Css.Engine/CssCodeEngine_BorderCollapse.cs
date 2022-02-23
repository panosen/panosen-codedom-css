namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string BorderCollapse = "border-collapse";

        private static void GenerateBorderCollapse(CodeWriter codeWriter, string borderCollapse, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, BorderCollapse, borderCollapse, options);
        }
    }
}
