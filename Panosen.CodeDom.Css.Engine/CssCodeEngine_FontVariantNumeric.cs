namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string FontVariantNumeric = "font-variant-numeric";

        private static void GenerateFontVariantNumeric(CodeWriter codeWriter, string fontVariantNumeric, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, FontVariantNumeric, fontVariantNumeric, options);
        }
    }
}
