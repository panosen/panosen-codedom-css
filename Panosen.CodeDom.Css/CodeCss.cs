using System;
using System.Collections.Generic;

namespace Panosen.CodeDom.Css
{
    /// <summary>
    /// css 样式
    /// </summary>
    public class CodeCss
    {

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 注释
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// 属性
        /// </summary>
        public List<CodeProperty> PropertyList { get; set; }
    }
}

