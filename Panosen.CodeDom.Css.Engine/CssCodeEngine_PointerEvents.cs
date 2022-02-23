namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string PointerEvents = "pointer-events";

        private static void GeneratePointerEvents(CodeWriter codeWriter, string pointerEvents, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, PointerEvents, pointerEvents, options);
        }
    }
}
