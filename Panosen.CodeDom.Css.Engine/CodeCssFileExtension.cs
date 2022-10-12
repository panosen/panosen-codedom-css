using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Css.Engine
{
    /// <summary>
    /// CodeCssFileExtension
    /// </summary>
    public static class CodeCssFileExtension
    {
        /// <summary>
        /// TransformText
        /// </summary>
        public static string TransformText(this CodeCssFile codeCssFile, GenerationOptions options = null)
        {
            var builder = new StringBuilder();

            new CssCodeEngine().Generate(codeCssFile, builder, options);

            return builder.ToString();
        }
    }
}
