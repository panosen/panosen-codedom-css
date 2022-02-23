namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string ListStyle = "list-style";

        private static void GenerateListStyle(CodeWriter codeWriter, string listStyle, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, ListStyle, listStyle, options);
        }
    }
}
