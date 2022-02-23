namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string Flex = "flex";

        private static void GenerateFlex(CodeWriter codeWriter, string flex, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, Flex, flex, options);
        }
    }
}
