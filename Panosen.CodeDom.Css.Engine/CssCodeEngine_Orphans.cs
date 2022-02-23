namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string Orphans = "orphans";

        private static void GenerateOrphans(CodeWriter codeWriter, string orphans, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, Orphans, orphans, options);
        }
    }
}
