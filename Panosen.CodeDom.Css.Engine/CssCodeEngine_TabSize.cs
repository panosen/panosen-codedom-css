namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string TabSize = "tab-size";

        private static void GenerateTabSize(CodeWriter codeWriter, string tabSize, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, TabSize, tabSize, options);
        }
    }
}
