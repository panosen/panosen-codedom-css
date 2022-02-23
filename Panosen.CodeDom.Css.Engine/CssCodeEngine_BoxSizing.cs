namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string BoxSizing = "box-sizing";

        private static void GenerateBoxSizing(CodeWriter codeWriter, string boxSizing, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, BoxSizing, boxSizing, options);
        }
    }
}
