namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string MaxWidth = "max-width";

        private static void GenerateMaxWidth(CodeWriter codeWriter, string maxWidth, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, MaxWidth, maxWidth, options);
        }
    }
}
