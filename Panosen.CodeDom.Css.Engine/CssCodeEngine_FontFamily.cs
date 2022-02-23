namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string FontFamily = "font-family";

        private static void GenerateFontFamily(CodeWriter codeWriter, string fontFamily, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, FontFamily, fontFamily, options);
        }
    }
}
