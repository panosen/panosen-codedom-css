namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string Perspective = "perspective";

        private static void GeneratePerspective(CodeWriter codeWriter, string perspective, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, Perspective, perspective, options);
        }
    }
}
