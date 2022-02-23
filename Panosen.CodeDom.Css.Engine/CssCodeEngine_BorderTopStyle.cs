namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string BorderTopStyle = "border-top-style";

        private static void GenerateBorderTopStyle(CodeWriter codeWriter, string borderTopStyle, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, BorderTopStyle, borderTopStyle, options);
        }
    }
}
