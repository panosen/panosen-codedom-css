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
        /// AddCss
        /// </summary>
        public static CodeCssFile AddCss(this CodeCssFile codeFile, CodeCss codeCss)
        {
            if (codeFile.CodeCssList == null)
            {
                codeFile.CodeCssList = new List<CodeCss>();
            }

            codeFile.CodeCssList.Add(codeCss);

            return codeFile;
        }

        /// <summary>
        /// AddCss
        /// </summary>
        public static CodeCss AddCss(this CodeCssFile codeFile, string name = null, string summary = null)
        {
            if (codeFile.CodeCssList == null)
            {
                codeFile.CodeCssList = new List<CodeCss>();
            }

            CodeCss codeCss = new CodeCss();
            codeCss.Name = name;
            codeCss.Summary = summary;

            codeFile.CodeCssList.Add(codeCss);

            return codeCss;
        }
    }
}
