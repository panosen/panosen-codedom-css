namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string Float = "float";

        private static void GenerateFloat(CodeWriter codeWriter, string @float, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, Float, @float, options);
        }
    }
}
