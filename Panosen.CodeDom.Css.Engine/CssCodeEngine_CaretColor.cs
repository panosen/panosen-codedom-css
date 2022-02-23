namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string CaretColor = "caret-color";

        private static void GenerateCaretColor(CodeWriter codeWriter, string caretColor, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, CaretColor, caretColor, options);
        }
    }
}
