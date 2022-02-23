namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string BackgroundSize = "background-size";

        private static void GenerateBackgroundSize(CodeWriter codeWriter, string backgroundSize, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, BackgroundSize, backgroundSize, options);
        }
    }
}
