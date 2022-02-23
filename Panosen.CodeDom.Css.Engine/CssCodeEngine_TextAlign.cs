namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string TextAlign = "text-align";

        private static void GenerateTextAlign(CodeWriter codeWriter, string textAlign, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, TextAlign, textAlign, options);
        }
    }
}
