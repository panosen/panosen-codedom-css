namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string FontSize = "font-size";

        private static void GenerateFontSize(CodeWriter codeWriter, string fontSize, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, FontSize, fontSize, options);
        }
    }
}
