namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string GridRowEnd = "grid-row-end";

        private static void GenerateGridRowEnd(CodeWriter codeWriter, string gridRowEnd, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, GridRowEnd, gridRowEnd, options);
        }
    }
}
