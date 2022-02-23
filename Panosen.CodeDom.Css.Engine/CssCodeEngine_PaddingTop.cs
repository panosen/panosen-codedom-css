namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string PaddingTop = "padding-top";

        private static void GeneratePaddingTop(CodeWriter codeWriter, string paddingTop, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, PaddingTop, paddingTop, options);
        }
    }
}
