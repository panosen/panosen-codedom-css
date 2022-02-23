namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string GridColumnGap = "grid-column-gap";

        private static void GenerateGridColumnGap(CodeWriter codeWriter, string gridColumnGap, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, GridColumnGap, gridColumnGap, options);
        }
    }
}
