namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string BorderImageOutset = "border-image-outset";

        private static void GenerateBorderImageOutset(CodeWriter codeWriter, string borderImageOutset, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, BorderImageOutset, borderImageOutset, options);
        }
    }
}
