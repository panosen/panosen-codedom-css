namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string BorderTop = "border-top";

        private static void GenerateBorderTop(CodeWriter codeWriter, string borderTop, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, BorderTop, borderTop, options);
        }
    }
}
