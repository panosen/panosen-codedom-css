namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// @import
        /// </summary>
        public string Import { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set @import
        /// </summary>
        public static TCodeCss SetImport<TCodeCss>(this TCodeCss codeCss, string import)
            where TCodeCss : CodeCss
        {
            codeCss.Import = import;

            return codeCss;
        }
    }
}
