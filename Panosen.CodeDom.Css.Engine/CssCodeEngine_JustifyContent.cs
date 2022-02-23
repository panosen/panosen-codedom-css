namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string JustifyContent = "justify-content";

        private static void GenerateJustifyContent(CodeWriter codeWriter, string justifyContent, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, JustifyContent, justifyContent, options);
        }
    }
}
