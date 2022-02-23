namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string BackgroundClip = "background-clip";

        private static void GenerateBackgroundClip(CodeWriter codeWriter, string backgroundClip, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, BackgroundClip, backgroundClip, options);
        }
    }
}
