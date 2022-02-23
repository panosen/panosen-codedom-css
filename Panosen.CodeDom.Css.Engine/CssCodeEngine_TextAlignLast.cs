namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string TextAlignLast = "text-align-last";

        private static void GenerateTextAlignLast(CodeWriter codeWriter, string textAlignLast, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, TextAlignLast, textAlignLast, options);
        }
    }
}
