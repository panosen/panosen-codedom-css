namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string FontWeight = "font-weight";

        private static void GenerateFontWeight(CodeWriter codeWriter, string fontWeight, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, FontWeight, fontWeight, options);
        }
    }
}
