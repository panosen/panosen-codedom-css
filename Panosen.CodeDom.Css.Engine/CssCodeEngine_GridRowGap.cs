namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string GridRowGap = "grid-row-gap";

        private static void GenerateGridRowGap(CodeWriter codeWriter, string gridRowGap, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, GridRowGap, gridRowGap, options);
        }
    }
}
