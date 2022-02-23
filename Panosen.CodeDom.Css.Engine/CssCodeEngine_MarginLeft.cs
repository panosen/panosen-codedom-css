namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string MarginLeft = "margin-left";

        private static void GenerateMarginLeft(CodeWriter codeWriter, string marginLeft, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, MarginLeft, marginLeft, options);
        }
    }
}
