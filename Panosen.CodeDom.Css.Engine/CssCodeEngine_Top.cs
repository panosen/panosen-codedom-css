namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string Top = "top";

        private static void GenerateTop(CodeWriter codeWriter, string top, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, Top, top, options);
        }
    }
}
