namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string PerspectiveOrigin = "perspective-origin";

        private static void GeneratePerspectiveOrigin(CodeWriter codeWriter, string perspectiveOrigin, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, PerspectiveOrigin, perspectiveOrigin, options);
        }
    }
}
