namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string ObjectFit = "object-fit";

        private static void GenerateObjectFit(CodeWriter codeWriter, string objectFit, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, ObjectFit, objectFit, options);
        }
    }
}
