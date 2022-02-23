namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string Media = "@media";

        private static void GenerateMedia(CodeWriter codeWriter, string media, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, Media, media, options);
        }
    }
}
