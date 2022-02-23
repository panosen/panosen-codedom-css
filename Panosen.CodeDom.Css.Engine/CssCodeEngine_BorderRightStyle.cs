namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string BorderRightStyle = "border-right-style";

        private static void GenerateBorderRightStyle(CodeWriter codeWriter, string borderRightStyle, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, BorderRightStyle, borderRightStyle, options);
        }
    }
}
