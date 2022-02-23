namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string FontVariantCaps = "font-variant-caps";

        private static void GenerateFontVariantCaps(CodeWriter codeWriter, string fontVariantCaps, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, FontVariantCaps, fontVariantCaps, options);
        }
    }
}
