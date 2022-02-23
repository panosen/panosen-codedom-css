namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string Isolation = "isolation";

        private static void GenerateIsolation(CodeWriter codeWriter, string isolation, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, Isolation, isolation, options);
        }
    }
}
