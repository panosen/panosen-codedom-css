namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string AlignSelf = "align-self";

        private static void GenerateAlignSelf(CodeWriter codeWriter, string alignSelf, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, AlignSelf, alignSelf, options);
        }
    }
}
