namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string OutlineWidth = "outline-width";

        private static void GenerateOutlineWidth(CodeWriter codeWriter, string outlineWidth, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, OutlineWidth, outlineWidth, options);
        }
    }
}
