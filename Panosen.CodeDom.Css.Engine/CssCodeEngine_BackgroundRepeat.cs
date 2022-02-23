namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string BackgroundRepeat = "background-repeat";

        private static void GenerateBackgroundRepeat(CodeWriter codeWriter, string backgroundRepeat, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, BackgroundRepeat, backgroundRepeat, options);
        }
    }
}
