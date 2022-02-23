namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string Position = "position";

        private static void GeneratePosition(CodeWriter codeWriter, string position, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, Position, position, options);
        }
    }
}
