namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string LineHeight = "line-height";

        private static void GenerateLineHeight(CodeWriter codeWriter, string lineHeight, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, LineHeight, lineHeight, options);
        }
    }
}
