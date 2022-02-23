namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string GridAutoRows = "grid-auto-rows";

        private static void GenerateGridAutoRows(CodeWriter codeWriter, string gridAutoRows, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, GridAutoRows, gridAutoRows, options);
        }
    }
}
