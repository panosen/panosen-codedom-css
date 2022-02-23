namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string FontSynthesis = "font-synthesis";

        private static void GenerateFontSynthesis(CodeWriter codeWriter, string fontSynthesis, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, FontSynthesis, fontSynthesis, options);
        }
    }
}
