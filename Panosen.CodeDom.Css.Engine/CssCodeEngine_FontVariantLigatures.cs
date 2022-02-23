namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string FontVariantLigatures = "font-variant-ligatures";

        private static void GenerateFontVariantLigatures(CodeWriter codeWriter, string fontVariantLigatures, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, FontVariantLigatures, fontVariantLigatures, options);
        }
    }
}
