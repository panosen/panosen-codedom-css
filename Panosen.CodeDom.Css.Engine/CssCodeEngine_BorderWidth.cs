namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string BorderWidth = "border-width";

        private static void GenerateBorderWidth(CodeWriter codeWriter, string borderWidth, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, BorderWidth, borderWidth, options);
        }
    }
}
