namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string Right = "right";

        private static void GenerateRight(CodeWriter codeWriter, string right, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, Right, right, options);
        }
    }
}
