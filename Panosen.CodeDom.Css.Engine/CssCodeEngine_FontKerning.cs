namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string FontKerning = "font-kerning";

        private static void GenerateFontKerning(CodeWriter codeWriter, string fontKerning, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, FontKerning, fontKerning, options);
        }
    }
}
