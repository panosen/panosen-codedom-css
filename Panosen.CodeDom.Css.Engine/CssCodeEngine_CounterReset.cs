namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string CounterReset = "counter-reset";

        private static void GenerateCounterReset(CodeWriter codeWriter, string counterReset, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, CounterReset, counterReset, options);
        }
    }
}
