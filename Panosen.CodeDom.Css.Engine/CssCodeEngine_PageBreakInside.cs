namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string PageBreakInside = "page-break-inside";

        private static void GeneratePageBreakInside(CodeWriter codeWriter, string pageBreakInside, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, PageBreakInside, pageBreakInside, options);
        }
    }
}
