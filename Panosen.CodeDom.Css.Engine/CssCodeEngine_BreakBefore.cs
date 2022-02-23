namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string BreakBefore = "break-before";

        private static void GenerateBreakBefore(CodeWriter codeWriter, string breakBefore, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, BreakBefore, breakBefore, options);
        }
    }
}
