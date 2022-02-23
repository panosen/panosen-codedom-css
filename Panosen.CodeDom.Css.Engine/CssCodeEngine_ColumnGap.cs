namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string ColumnGap = "column-gap";

        private static void GenerateColumnGap(CodeWriter codeWriter, string columnGap, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, ColumnGap, columnGap, options);
        }
    }
}
