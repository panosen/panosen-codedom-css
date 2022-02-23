namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string FlexGrow = "flex-grow";

        private static void GenerateFlexGrow(CodeWriter codeWriter, string flexGrow, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, FlexGrow, flexGrow, options);
        }
    }
}
