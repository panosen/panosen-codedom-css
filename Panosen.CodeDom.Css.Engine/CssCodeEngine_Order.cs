namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string Order = "order";

        private static void GenerateOrder(CodeWriter codeWriter, string order, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, Order, order, options);
        }
    }
}
