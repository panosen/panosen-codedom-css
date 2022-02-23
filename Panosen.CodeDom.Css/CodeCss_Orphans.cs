namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// orphans
        /// </summary>
        public string Orphans { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set orphans
        /// </summary>
        public static TCodeCss SetOrphans<TCodeCss>(this TCodeCss codeCss, string orphans)
            where TCodeCss : CodeCss
        {
            codeCss.Orphans = orphans;

            return codeCss;
        }
    }
}
