namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string VerticalAlign = "vertical-align";

        private static void GenerateVerticalAlign(CodeWriter codeWriter, string verticalAlign, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, VerticalAlign, verticalAlign, options);
        }
    }
}
