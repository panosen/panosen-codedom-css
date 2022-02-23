namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string FontFeatureSettings = "font-feature-settings";

        private static void GenerateFontFeatureSettings(CodeWriter codeWriter, string fontFeatureSettings, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, FontFeatureSettings, fontFeatureSettings, options);
        }
    }
}
