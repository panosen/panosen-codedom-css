using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Css.Engine
{
    /// <summary>
    /// CodeCssExtension
    /// </summary>
    public static class CodeCssExtension
    {
        /// <summary>
        /// TransformText
        /// </summary>
        public static string TransformText(this CodeCss codeCss, GenerationOptions options = null)
        {
            var builder = new StringBuilder();

            new CssCodeEngine().Generate(codeCss, builder, options);

            return builder.ToString();
        }
    }
}
