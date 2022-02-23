namespace Panosen.CodeDom.Css.Engine
{

    partial class CssCodeEngine
    {

        private const string Filter = "filter";

        private static void GenerateFilter(CodeWriter codeWriter, string filter, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, Filter, filter, options);
        }
    }
}
