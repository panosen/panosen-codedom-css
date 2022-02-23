namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string PaddingRight = "padding-right";

        private static void GeneratePaddingRight(CodeWriter codeWriter, string paddingRight, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, PaddingRight, paddingRight, options);
        }
    }
}
