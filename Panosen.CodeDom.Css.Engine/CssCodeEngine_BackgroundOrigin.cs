namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string BackgroundOrigin = "background-origin";

        private static void GenerateBackgroundOrigin(CodeWriter codeWriter, string backgroundOrigin, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, BackgroundOrigin, backgroundOrigin, options);
        }
    }
}
