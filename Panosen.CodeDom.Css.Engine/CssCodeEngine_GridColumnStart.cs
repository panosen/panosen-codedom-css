namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string GridColumnStart = "grid-column-start";

        private static void GenerateGridColumnStart(CodeWriter codeWriter, string gridColumnStart, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, GridColumnStart, gridColumnStart, options);
        }
    }
}
