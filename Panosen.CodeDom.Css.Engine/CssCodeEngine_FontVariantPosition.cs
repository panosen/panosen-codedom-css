namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string FontVariantPosition = "font-variant-position";

        private static void GenerateFontVariantPosition(CodeWriter codeWriter, string fontVariantPosition, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, FontVariantPosition, fontVariantPosition, options);
        }
    }
}
