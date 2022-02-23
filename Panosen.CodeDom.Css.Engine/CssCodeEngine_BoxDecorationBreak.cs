namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string BoxDecorationBreak = "box-decoration-break";

        private static void GenerateBoxDecorationBreak(CodeWriter codeWriter, string boxDecorationBreak, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, BoxDecorationBreak, boxDecorationBreak, options);
        }
    }
}
