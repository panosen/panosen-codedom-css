namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string Border = "border";

        private static void GenerateBorder(CodeWriter codeWriter, string border, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, Border, border, options);
        }
    }
}
