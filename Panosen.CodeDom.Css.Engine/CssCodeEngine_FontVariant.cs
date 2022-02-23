namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string FontVariant = "font-variant";

        private static void GenerateFontVariant(CodeWriter codeWriter, string fontVariant, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, FontVariant, fontVariant, options);
        }
    }
}
