namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string BorderTopRightRadius = "border-top-right-radius";

        private static void GenerateBorderTopRightRadius(CodeWriter codeWriter, string borderTopRightRadius, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, BorderTopRightRadius, borderTopRightRadius, options);
        }
    }
}
