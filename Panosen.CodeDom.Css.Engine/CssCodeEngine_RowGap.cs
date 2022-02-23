namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string RowGap = "row-gap";

        private static void GenerateRowGap(CodeWriter codeWriter, string rowGap, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, RowGap, rowGap, options);
        }
    }
}
