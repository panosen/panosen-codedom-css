namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string AlignItems = "align-items";

        private static void GenerateAlignItems(CodeWriter codeWriter, string alignItems, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, AlignItems, alignItems, options);
        }
    }
}
