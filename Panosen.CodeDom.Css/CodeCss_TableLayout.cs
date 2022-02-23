namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// table-layout
        /// </summary>
        public string TableLayout { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set table-layout
        /// </summary>
        public static TCodeCss SetTableLayout<TCodeCss>(this TCodeCss codeCss, string tableLayout)
            where TCodeCss : CodeCss
        {
            codeCss.TableLayout = tableLayout;

            return codeCss;
        }
    }
}
