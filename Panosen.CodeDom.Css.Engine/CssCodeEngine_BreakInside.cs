namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string BreakInside = "break-inside";

        private static void GenerateBreakInside(CodeWriter codeWriter, string breakInside, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, BreakInside, breakInside, options);
        }
    }
}
