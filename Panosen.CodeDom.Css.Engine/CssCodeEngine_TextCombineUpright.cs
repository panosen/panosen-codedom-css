namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string TextCombineUpright = "text-combine-upright";

        private static void GenerateTextCombineUpright(CodeWriter codeWriter, string textCombineUpright, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, TextCombineUpright, textCombineUpright, options);
        }
    }
}
