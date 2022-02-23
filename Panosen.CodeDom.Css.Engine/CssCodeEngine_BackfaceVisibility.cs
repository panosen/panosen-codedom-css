namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string BackfaceVisibility = "backface-visibility";

        private static void GenerateBackfaceVisibility(CodeWriter codeWriter, string backfaceVisibility, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, BackfaceVisibility, backfaceVisibility, options);
        }
    }
}
