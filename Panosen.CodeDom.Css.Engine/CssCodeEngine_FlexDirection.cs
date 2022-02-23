namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string FlexDirection = "flex-direction";

        private static void GenerateFlexDirection(CodeWriter codeWriter, string flexDirection, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, FlexDirection, flexDirection, options);
        }
    }
}
