namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string MinHeight = "min-height";

        private static void GenerateMinHeight(CodeWriter codeWriter, string minHeight, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, MinHeight, minHeight, options);
        }
    }
}
