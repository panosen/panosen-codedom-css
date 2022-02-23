namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string FontVariantAlternates = "font-variant-alternates";

        private static void GenerateFontVariantAlternates(CodeWriter codeWriter, string fontVariantAlternates, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, FontVariantAlternates, fontVariantAlternates, options);
        }
    }
}
