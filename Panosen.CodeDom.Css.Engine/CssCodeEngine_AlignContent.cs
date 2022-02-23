namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string AlignContent = "align-content";

        private static void GenerateAlignContent(CodeWriter codeWriter, string alignContent, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, AlignContent, alignContent, options);
        }
    }
}
