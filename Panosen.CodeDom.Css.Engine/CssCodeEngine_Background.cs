namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string Background = "background";

        private static void GenerateBackground(CodeWriter codeWriter, string background, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, Background, background, options);
        }
    }
}
