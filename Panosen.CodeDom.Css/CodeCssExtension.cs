using System;

namespace Panosen.CodeDom.Css
{
    /// <summary>
    /// css 样式
    /// </summary>
    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set Name
        /// </summary>
        /// <param name="codeCss"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static TCodeCss SetName<TCodeCss>(this TCodeCss codeCss, string name) where TCodeCss : CodeCss
        {
            codeCss.Name = name;

            return codeCss;
        }

        /// <summary>
        /// set Comment
        /// </summary>
        /// <param name="codeCss"></param>
        /// <param name="comment"></param>
        /// <returns></returns>
        public static TCodeCss SetComment<TCodeCss>(this TCodeCss codeCss, string comment) where TCodeCss : CodeCss
        {
            codeCss.Comment = comment;

            return codeCss;
        }
    }
}
