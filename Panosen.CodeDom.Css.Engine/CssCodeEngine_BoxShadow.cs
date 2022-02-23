namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string BoxShadow = "box-shadow";

        private static void GenerateBoxShadow(CodeWriter codeWriter, string boxShadow, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, BoxShadow, boxShadow, options);
        }
    }
}
