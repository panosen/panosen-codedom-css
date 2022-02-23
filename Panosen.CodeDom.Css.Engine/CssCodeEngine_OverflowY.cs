namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string OverflowY = "overflow-y";

        private static void GenerateOverflowY(CodeWriter codeWriter, string overflowY, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, OverflowY, overflowY, options);
        }
    }
}
