namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string FontStyle = "font-style";

        private static void GenerateFontStyle(CodeWriter codeWriter, string fontStyle, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, FontStyle, fontStyle, options);
        }
    }
}
