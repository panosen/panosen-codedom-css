namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string FontStretch = "font-stretch";

        private static void GenerateFontStretch(CodeWriter codeWriter, string fontStretch, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, FontStretch, fontStretch, options);
        }
    }
}
