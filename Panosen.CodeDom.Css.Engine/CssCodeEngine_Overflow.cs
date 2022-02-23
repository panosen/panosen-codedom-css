namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string Overflow = "overflow";

        private static void GenerateOverflow(CodeWriter codeWriter, string overflow, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, Overflow, overflow, options);
        }
    }
}
