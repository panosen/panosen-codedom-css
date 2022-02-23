namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string GridTemplate = "grid-template";

        private static void GenerateGridTemplate(CodeWriter codeWriter, string gridTemplate, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, GridTemplate, gridTemplate, options);
        }
    }
}
