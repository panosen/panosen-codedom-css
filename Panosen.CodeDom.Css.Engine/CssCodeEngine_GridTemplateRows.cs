namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string GridTemplateRows = "grid-template-rows";

        private static void GenerateGridTemplateRows(CodeWriter codeWriter, string gridTemplateRows, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, GridTemplateRows, gridTemplateRows, options);
        }
    }
}
