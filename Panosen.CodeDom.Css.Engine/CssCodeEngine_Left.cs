namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string Left = "left";

        private static void GenerateLeft(CodeWriter codeWriter, string left, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, Left, left, options);
        }
    }
}
