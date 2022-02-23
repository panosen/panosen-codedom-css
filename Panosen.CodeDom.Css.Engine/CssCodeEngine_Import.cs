namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string Import = "@import";

        private static void GenerateImport(CodeWriter codeWriter, string import, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, Import, import, options);
        }
    }
}
