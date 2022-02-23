namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string GridTemplateAreas = "grid-template-areas";

        private static void GenerateGridTemplateAreas(CodeWriter codeWriter, string gridTemplateAreas, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, GridTemplateAreas, gridTemplateAreas, options);
        }
    }
}
