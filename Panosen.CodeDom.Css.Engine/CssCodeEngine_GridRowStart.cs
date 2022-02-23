namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string GridRowStart = "grid-row-start";

        private static void GenerateGridRowStart(CodeWriter codeWriter, string gridRowStart, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, GridRowStart, gridRowStart, options);
        }
    }
}
