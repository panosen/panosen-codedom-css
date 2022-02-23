namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string Resize = "resize";

        private static void GenerateResize(CodeWriter codeWriter, string resize, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, Resize, resize, options);
        }
    }
}
