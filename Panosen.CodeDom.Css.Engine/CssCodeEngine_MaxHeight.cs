namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string MaxHeight = "max-height";

        private static void GenerateMaxHeight(CodeWriter codeWriter, string maxHeight, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, MaxHeight, maxHeight, options);
        }
    }
}
