namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string Margin = "margin";

        private static void GenerateMargin(CodeWriter codeWriter, string margin, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, Margin, margin, options);
        }
    }
}
