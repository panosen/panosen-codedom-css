namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string BorderBottomStyle = "border-bottom-style";

        private static void GenerateBorderBottomStyle(CodeWriter codeWriter, string borderBottomStyle, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, BorderBottomStyle, borderBottomStyle, options);
        }
    }
}
