namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string GridAutoColumns = "grid-auto-columns";

        private static void GenerateGridAutoColumns(CodeWriter codeWriter, string gridAutoColumns, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, GridAutoColumns, gridAutoColumns, options);
        }
    }
}
