namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string BorderImageRepeat = "border-image-repeat";

        private static void GenerateBorderImageRepeat(CodeWriter codeWriter, string borderImageRepeat, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, BorderImageRepeat, borderImageRepeat, options);
        }
    }
}
