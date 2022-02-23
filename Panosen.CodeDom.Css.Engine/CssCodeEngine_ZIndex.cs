namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string ZIndex = "z-index";

        private static void GenerateZIndex(CodeWriter codeWriter, string zindex, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, ZIndex, zindex, options);
        }
    }
}
