namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string CounterIncrement = "counter-increment";

        private static void GenerateCounterIncrement(CodeWriter codeWriter, string counterIncrement, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, CounterIncrement, counterIncrement, options);
        }
    }
}
