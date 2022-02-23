namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string ListStylePosition = "list-style-position";

        private static void GenerateListStylePosition(CodeWriter codeWriter, string listStylePosition, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, ListStylePosition, listStylePosition, options);
        }
    }
}
