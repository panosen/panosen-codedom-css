namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string All = "all";

        private static void GenerateAll(CodeWriter codeWriter, string all, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, All, all, options);
        }
    }
}
