namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string FontFace = "@font-face";

        private static void GenerateFontFace(CodeWriter codeWriter, string fontFace, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, FontFace, fontFace, options);
        }
    }
}
