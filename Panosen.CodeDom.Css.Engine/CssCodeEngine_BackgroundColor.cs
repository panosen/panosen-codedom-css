namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string BackgroundColor = "background-color";

        private static void GenerateBackgroundColor(CodeWriter codeWriter, string backgroundColor, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, BackgroundColor, backgroundColor, options);
        }
    }
}
