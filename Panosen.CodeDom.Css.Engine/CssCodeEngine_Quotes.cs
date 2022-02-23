namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string Quotes = "quotes";

        private static void GenerateQuotes(CodeWriter codeWriter, string quotes, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, Quotes, quotes, options);
        }
    }
}
