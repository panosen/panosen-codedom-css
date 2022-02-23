namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string OverflowX = "overflow-x";

        private static void GenerateOverflowX(CodeWriter codeWriter, string overflowX, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, OverflowX, overflowX, options);
        }
    }
}
