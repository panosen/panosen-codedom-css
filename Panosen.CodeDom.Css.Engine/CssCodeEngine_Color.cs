namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string Color = "color";

        private static void GenerateColor(CodeWriter codeWriter, string color, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, Color, color, options);
        }
    }
}
