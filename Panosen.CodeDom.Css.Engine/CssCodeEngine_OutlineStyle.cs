namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string OutlineStyle = "outline-style";

        private static void GenerateOutlineStyle(CodeWriter codeWriter, string outlineStyle, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, OutlineStyle, outlineStyle, options);
        }
    }
}
