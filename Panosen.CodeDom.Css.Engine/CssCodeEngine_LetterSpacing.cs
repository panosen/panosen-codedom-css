namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string LetterSpacing = "letter-spacing";

        private static void GenerateLetterSpacing(CodeWriter codeWriter, string letterSpacing, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, LetterSpacing, letterSpacing, options);
        }
    }
}
