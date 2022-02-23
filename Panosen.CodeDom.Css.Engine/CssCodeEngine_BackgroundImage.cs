namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string BackgroundImage = "background-image";

        private static void GenerateBackgroundImage(CodeWriter codeWriter, string backgroundImage, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, BackgroundImage, backgroundImage, options);
        }
    }
}
