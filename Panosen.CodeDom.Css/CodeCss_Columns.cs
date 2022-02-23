namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// columns
        /// </summary>
        public string Columns { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set columns
        /// </summary>
        public static TCodeCss SetColumns<TCodeCss>(this TCodeCss codeCss, string columns)
            where TCodeCss : CodeCss
        {
            codeCss.Columns = columns;

            return codeCss;
        }
    }
}
