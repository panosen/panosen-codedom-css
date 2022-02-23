namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string Font = "font";

        private static void GenerateFont(CodeWriter codeWriter, string font, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, Font, font, options);
        }
    }
}
