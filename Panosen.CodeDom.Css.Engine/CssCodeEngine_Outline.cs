namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string Outline = "outline";

        private static void GenerateOutline(CodeWriter codeWriter, string outline, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, Outline, outline, options);
        }
    }
}
