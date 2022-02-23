namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string Width = "width";

        private static void GenerateWidth(CodeWriter codeWriter, string width, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, Width, width, options);
        }
    }
}
