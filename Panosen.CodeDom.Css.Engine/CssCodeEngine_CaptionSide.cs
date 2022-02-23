namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string CaptionSide = "caption-side";

        private static void GenerateCaptionSide(CodeWriter codeWriter, string captionSide, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, CaptionSide, captionSide, options);
        }
    }
}
