namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string BackgroundPosition = "background-position";

        private static void GenerateBackgroundPosition(CodeWriter codeWriter, string backgroundPosition, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, BackgroundPosition, backgroundPosition, options);
        }
    }
}
