namespace Panosen.CodeDom.Css
{

    public partial class CodeCss
    {

        /// <summary>
        /// object-fit
        /// </summary>
        public string ObjectFit { get; set; }
    }

    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set object-fit
        /// </summary>
        public static TCodeCss SetObjectFit<TCodeCss>(this TCodeCss codeCss, string objectFit)
            where TCodeCss : CodeCss
        {
            codeCss.ObjectFit = objectFit;

            return codeCss;
        }
    }
}
