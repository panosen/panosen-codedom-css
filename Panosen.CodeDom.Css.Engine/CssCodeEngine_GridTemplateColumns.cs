namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string GridTemplateColumns = "grid-template-columns";

        private static void GenerateGridTemplateColumns(CodeWriter codeWriter, string gridTemplateColumns, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, GridTemplateColumns, gridTemplateColumns, options);
        }
    }
}
