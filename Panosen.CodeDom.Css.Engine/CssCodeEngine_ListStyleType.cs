namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string ListStyleType = "list-style-type";

        private static void GenerateListStyleType(CodeWriter codeWriter, string listStyleType, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, ListStyleType, listStyleType, options);
        }
    }
}
