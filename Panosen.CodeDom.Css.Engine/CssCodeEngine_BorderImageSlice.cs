namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string BorderImageSlice = "border-image-slice";

        private static void GenerateBorderImageSlice(CodeWriter codeWriter, string borderImageSlice, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, BorderImageSlice, borderImageSlice, options);
        }
    }
}
