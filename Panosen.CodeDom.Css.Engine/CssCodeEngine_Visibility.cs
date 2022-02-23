namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string Visibility = "visibility";

        private static void GenerateVisibility(CodeWriter codeWriter, string visibility, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, Visibility, visibility, options);
        }
    }
}
