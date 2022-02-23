namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string Cursor = "cursor";

        private static void GenerateCursor(CodeWriter codeWriter, string cursor, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, Cursor, cursor, options);
        }
    }
}
