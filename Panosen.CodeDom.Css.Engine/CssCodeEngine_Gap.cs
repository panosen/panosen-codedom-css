namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string Gap = "gap";

        private static void GenerateGap(CodeWriter codeWriter, string gap, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, Gap, gap, options);
        }
    }
}
