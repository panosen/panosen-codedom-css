namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string PageBreakBefore = "page-break-before";

        private static void GeneratePageBreakBefore(CodeWriter codeWriter, string pageBreakBefore, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, PageBreakBefore, pageBreakBefore, options);
        }
    }
}
