using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Css
{
    /// <summary>
    /// css 文件
    /// </summary>
    public class CodeCssFile
    {
        /// <summary>
        ///注释
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// css 样式
        /// </summary>
        public List<CodeCss> CodeCssList { get; set; }
    }
}
