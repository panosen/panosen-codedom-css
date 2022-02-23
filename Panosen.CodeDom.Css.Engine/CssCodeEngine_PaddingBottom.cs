namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string PaddingBottom = "padding-bottom";

        private static void GeneratePaddingBottom(CodeWriter codeWriter, string paddingBottom, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, PaddingBottom, paddingBottom, options);
        }
    }
}
