namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string ObjectPosition = "object-position";

        private static void GenerateObjectPosition(CodeWriter codeWriter, string objectPosition, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, ObjectPosition, objectPosition, options);
        }
    }
}
