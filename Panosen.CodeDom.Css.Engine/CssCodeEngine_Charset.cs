namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string Charset = "@charset";

        private static void GenerateCharset(CodeWriter codeWriter, string charset, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, Charset, charset, options);
        }
    }
}
