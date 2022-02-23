namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string GridGap = "grid-gap";

        private static void GenerateGridGap(CodeWriter codeWriter, string gridGap, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, GridGap, gridGap, options);
        }
    }
}
