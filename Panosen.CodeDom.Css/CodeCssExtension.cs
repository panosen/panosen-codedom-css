using System;
using System.Collections.Generic;

namespace Panosen.CodeDom.Css
{
    /// <summary>
    /// css 样式
    /// </summary>
    public static partial class CodeCssExtension
    {
        /// <summary>
        /// 设置名称
        /// </summary>
        public static TCodeCss SetName<TCodeCss>(this TCodeCss codeCss, string name)
            where TCodeCss : CodeCss
        {
            codeCss.Name = name;

            return codeCss;
        }

        /// <summary>
        /// 设置注释
        /// </summary>
        public static TCodeCss SetSummary<TCodeCss>(this TCodeCss codeCss, string summary)
            where TCodeCss : CodeCss
        {
            codeCss.Summary = summary;

            return codeCss;
        }

        /// <summary>
        /// 添加属性
        /// </summary>
        public static TCodeCss AddProperty<TCodeCss>(this TCodeCss codeCss, string name, string valule, string summary = null)
            where TCodeCss : CodeCss
        {
            if (codeCss.PropertyList == null)
            {
                codeCss.PropertyList = new List<CodeProperty>();
            }

            var property = new CodeProperty();
            property.Name = name;
            property.Value = valule;
            property.Summary = summary;

            codeCss.PropertyList.Add(property);

            return codeCss;
        }
    }
}
