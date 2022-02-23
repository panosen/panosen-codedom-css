namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string MarginRight = "margin-right";

        private static void GenerateMarginRight(CodeWriter codeWriter, string marginRight, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, MarginRight, marginRight, options);
        }
    }
}
