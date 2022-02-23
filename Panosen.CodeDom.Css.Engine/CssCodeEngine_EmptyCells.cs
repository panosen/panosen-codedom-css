namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string EmptyCells = "empty-cells";

        private static void GenerateEmptyCells(CodeWriter codeWriter, string emptyCells, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, EmptyCells, emptyCells, options);
        }
    }
}
