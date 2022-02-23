namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string BorderSpacing = "border-spacing";

        private static void GenerateBorderSpacing(CodeWriter codeWriter, string borderSpacing, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, BorderSpacing, borderSpacing, options);
        }
    }
}
