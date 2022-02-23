namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string Hyphens = "hyphens";

        private static void GenerateHyphens(CodeWriter codeWriter, string hyphens, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, Hyphens, hyphens, options);
        }
    }
}
