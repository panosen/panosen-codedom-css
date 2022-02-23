namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string FlexFlow = "flex-flow";

        private static void GenerateFlexFlow(CodeWriter codeWriter, string flexFlow, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, FlexFlow, flexFlow, options);
        }
    }
}
