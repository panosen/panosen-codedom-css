namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string LineBreak = "line-break";

        private static void GenerateLineBreak(CodeWriter codeWriter, string lineBreak, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, LineBreak, lineBreak, options);
        }
    }
}
