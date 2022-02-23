namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string MarginTop = "margin-top";

        private static void GenerateMarginTop(CodeWriter codeWriter, string marginTop, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, MarginTop, marginTop, options);
        }
    }
}
