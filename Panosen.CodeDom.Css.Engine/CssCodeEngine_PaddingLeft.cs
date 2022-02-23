namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string PaddingLeft = "padding-left";

        private static void GeneratePaddingLeft(CodeWriter codeWriter, string paddingLeft, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, PaddingLeft, paddingLeft, options);
        }
    }
}
