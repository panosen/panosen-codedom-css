namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string FontSizeAdjust = "font-size-adjust";

        private static void GenerateFontSizeAdjust(CodeWriter codeWriter, string fontSizeAdjust, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, FontSizeAdjust, fontSizeAdjust, options);
        }
    }
}
