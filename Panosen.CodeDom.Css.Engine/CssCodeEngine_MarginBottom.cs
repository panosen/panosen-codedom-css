namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string MarginBottom = "margin-bottom";

        private static void GenerateMarginBottom(CodeWriter codeWriter, string marginBottom, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, MarginBottom, marginBottom, options);
        }
    }
}
