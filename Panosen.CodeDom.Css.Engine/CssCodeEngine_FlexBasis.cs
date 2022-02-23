namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string FlexBasis = "flex-basis";

        private static void GenerateFlexBasis(CodeWriter codeWriter, string flexBasis, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, FlexBasis, flexBasis, options);
        }
    }
}
