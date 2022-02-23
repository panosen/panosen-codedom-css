namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string FontLanguageOverride = "font-language-override";

        private static void GenerateFontLanguageOverride(CodeWriter codeWriter, string fontLanguageOverride, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, FontLanguageOverride, fontLanguageOverride, options);
        }
    }
}
