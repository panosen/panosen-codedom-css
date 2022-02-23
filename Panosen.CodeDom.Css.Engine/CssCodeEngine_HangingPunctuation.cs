namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string HangingPunctuation = "hanging-punctuation";

        private static void GenerateHangingPunctuation(CodeWriter codeWriter, string hangingPunctuation, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, HangingPunctuation, hangingPunctuation, options);
        }
    }
}
