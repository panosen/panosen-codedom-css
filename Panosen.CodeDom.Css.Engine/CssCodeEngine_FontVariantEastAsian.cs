namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string FontVariantEastAsian = "font-variant-east-asian";

        private static void GenerateFontVariantEastAsian(CodeWriter codeWriter, string fontVariantEastAsian, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, FontVariantEastAsian, fontVariantEastAsian, options);
        }
    }
}
