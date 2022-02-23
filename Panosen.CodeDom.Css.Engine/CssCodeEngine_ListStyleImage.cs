namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string ListStyleImage = "list-style-image";

        private static void GenerateListStyleImage(CodeWriter codeWriter, string listStyleImage, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, ListStyleImage, listStyleImage, options);
        }
    }
}
