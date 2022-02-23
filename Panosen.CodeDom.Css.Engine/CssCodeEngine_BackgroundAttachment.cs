namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string BackgroundAttachment = "background-attachment";

        private static void GenerateBackgroundAttachment(CodeWriter codeWriter, string backgroundAttachment, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, BackgroundAttachment, backgroundAttachment, options);
        }
    }
}
