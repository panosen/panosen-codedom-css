namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string BorderBottom = "border-bottom";

        private static void GenerateBorderBottom(CodeWriter codeWriter, string borderBottom, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, BorderBottom, borderBottom, options);
        }
    }
}
