namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string FlexShrink = "flex-shrink";

        private static void GenerateFlexShrink(CodeWriter codeWriter, string flexShrink, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, FlexShrink, flexShrink, options);
        }
    }
}
