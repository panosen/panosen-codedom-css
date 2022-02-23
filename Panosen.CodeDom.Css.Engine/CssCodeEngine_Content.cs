namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string Content = "content";

        private static void GenerateContent(CodeWriter codeWriter, string content, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, Content, content, options);
        }
    }
}
