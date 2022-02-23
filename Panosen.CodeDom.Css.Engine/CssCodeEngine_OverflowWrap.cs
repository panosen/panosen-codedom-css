namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string OverflowWrap = "overflow-wrap";

        private static void GenerateOverflowWrap(CodeWriter codeWriter, string overflowWrap, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, OverflowWrap, overflowWrap, options);
        }
    }
}
