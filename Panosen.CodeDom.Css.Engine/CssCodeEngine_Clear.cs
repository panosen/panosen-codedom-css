namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string Clear = "clear";

        private static void GenerateClear(CodeWriter codeWriter, string clear, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, Clear, clear, options);
        }
    }
}
