namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string OutlineOffset = "outline-offset";

        private static void GenerateOutlineOffset(CodeWriter codeWriter, string outlineOffset, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, OutlineOffset, outlineOffset, options);
        }
    }
}
