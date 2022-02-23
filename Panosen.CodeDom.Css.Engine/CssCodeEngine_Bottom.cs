namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string Bottom = "bottom";

        private static void GenerateBottom(CodeWriter codeWriter, string bottom, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, Bottom, bottom, options);
        }
    }
}
