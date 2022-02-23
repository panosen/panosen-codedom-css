namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string GridAutoFlow = "grid-auto-flow";

        private static void GenerateGridAutoFlow(CodeWriter codeWriter, string gridAutoFlow, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, GridAutoFlow, gridAutoFlow, options);
        }
    }
}
