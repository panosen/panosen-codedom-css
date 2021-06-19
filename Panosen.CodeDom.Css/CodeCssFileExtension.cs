using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Css
{
    /// <summary>
    /// extension
    /// </summary>
    public static class CodeCssFileExtension
    {
        /// <summary>
        /// add css
        /// </summary>
        /// <param name="codeFile"></param>
        /// <param name="codeCss"></param>
        public static CodeCssFile AddCodeCss(this CodeCssFile codeFile, CodeCss codeCss)
        {
            if (codeFile.CodeCssList == null)
            {
                codeFile.CodeCssList = new List<CodeCss>();
            }

            codeFile.CodeCssList.Add(codeCss);

            return codeFile;
        }

        /// <summary>
        /// add css
        /// </summary>
        /// <param name="codeFile"></param>
        /// <param name="name"></param>
        /// <param name="comment"></param>
        public static CodeCss AddCodeCss(this CodeCssFile codeFile, string name = null, string comment = null)
        {
            if (codeFile.CodeCssList == null)
            {
                codeFile.CodeCssList = new List<CodeCss>();
            }

            CodeCss codeCss = new CodeCss();
            codeCss.Name = name;
            codeCss.Comment = comment;

            codeFile.CodeCssList.Add(codeCss);

            return codeCss;
        }
    }
}
