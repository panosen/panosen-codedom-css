namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string OutlineColor = "outline-color";

        private static void GenerateOutlineColor(CodeWriter codeWriter, string outlineColor, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, OutlineColor, outlineColor, options);
        }
    }
}
