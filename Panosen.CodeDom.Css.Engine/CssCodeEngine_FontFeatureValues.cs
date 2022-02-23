namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string FontFeatureValues = "@font-feature-values";

        private static void GenerateFontFeatureValues(CodeWriter codeWriter, string fontFeatureValues, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, FontFeatureValues, fontFeatureValues, options);
        }
    }
}
