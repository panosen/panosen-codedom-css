namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string ScrollBehavior = "scroll-behavior";

        private static void GenerateScrollBehavior(CodeWriter codeWriter, string scrollBehavior, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, ScrollBehavior, scrollBehavior, options);
        }
    }
}
