namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string Columns = "columns";

        private static void GenerateColumns(CodeWriter codeWriter, string columns, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, Columns, columns, options);
        }
    }
}
