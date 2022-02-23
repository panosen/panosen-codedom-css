namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string GridColumnEnd = "grid-column-end";

        private static void GenerateGridColumnEnd(CodeWriter codeWriter, string gridColumnEnd, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, GridColumnEnd, gridColumnEnd, options);
        }
    }
}
