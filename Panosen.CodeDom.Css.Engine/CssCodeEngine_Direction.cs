namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string Direction = "direction";

        private static void GenerateDirection(CodeWriter codeWriter, string direction, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, Direction, direction, options);
        }
    }
}
