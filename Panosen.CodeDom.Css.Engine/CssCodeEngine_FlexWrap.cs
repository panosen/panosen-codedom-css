namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string FlexWrap = "flex-wrap";

        private static void GenerateFlexWrap(CodeWriter codeWriter, string flexWrap, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, FlexWrap, flexWrap, options);
        }
    }
}
