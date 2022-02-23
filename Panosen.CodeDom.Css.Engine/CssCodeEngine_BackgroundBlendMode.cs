namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string BackgroundBlendMode = "background-blend-mode";

        private static void GenerateBackgroundBlendMode(CodeWriter codeWriter, string backgroundBlendMode, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, BackgroundBlendMode, backgroundBlendMode, options);
        }
    }
}
