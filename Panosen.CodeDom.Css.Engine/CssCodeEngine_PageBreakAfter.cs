namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string PageBreakAfter = "page-break-after";

        private static void GeneratePageBreakAfter(CodeWriter codeWriter, string pageBreakAfter, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, PageBreakAfter, pageBreakAfter, options);
        }
    }
}
