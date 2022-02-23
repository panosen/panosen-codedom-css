namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string Opacity = "opacity";

        private static void GenerateOpacity(CodeWriter codeWriter, string opacity, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, Opacity, opacity, options);
        }
    }
}
