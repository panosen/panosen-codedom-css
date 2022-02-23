namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string BreakAfter = "break-after";

        private static void GenerateBreakAfter(CodeWriter codeWriter, string breakAfter, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, BreakAfter, breakAfter, options);
        }
    }
}
