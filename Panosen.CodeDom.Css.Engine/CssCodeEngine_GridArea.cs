namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string GridArea = "grid-area";

        private static void GenerateGridArea(CodeWriter codeWriter, string gridArea, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, GridArea, gridArea, options);
        }
    }
}
