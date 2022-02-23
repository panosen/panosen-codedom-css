namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string MinWidth = "min-width";

        private static void GenerateMinWidth(CodeWriter codeWriter, string minWidth, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, MinWidth, minWidth, options);
        }
    }
}
