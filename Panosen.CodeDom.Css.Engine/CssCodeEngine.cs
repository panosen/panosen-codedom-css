using System;
using System.Collections.Generic;
using System.Linq;
using Panosen.CodeDom;

namespace Panosen.CodeDom.Css.Engine
{
    /// <summary>
    /// css 代码引擎
    /// </summary>
    public partial class CssCodeEngine
    {
        /// <summary>
        /// 生成css文件
        /// </summary>
        public void Generate(CodeCssFile codeFile, CodeWriter codeWriter, GenerationOptions options = null)
        {
            if (codeFile == null) { return; }
            if (codeWriter == null) { return; }
            options = options ?? new GenerationOptions();

            if (!string.IsNullOrEmpty(codeFile.Summary))
            {
                codeWriter.Write(options.IndentString)
                    .Write(Marks.SLASH).Write(Marks.STAR).WriteLine(Marks.Exclamation)
                    .Write(Marks.WHITESPACE).Write(Marks.STAR).Write(Marks.WHITESPACE).WriteLine(codeFile.Summary)
                    .Write(Marks.WHITESPACE).Write(Marks.STAR).WriteLine(Marks.SLASH);
                codeWriter.WriteLine();
            }

            Generate(codeFile.CodeCssList, codeWriter, options);
        }

        /// <summary>
        /// 生成 css 列表
        /// </summary>
        public void Generate(List<CodeCss> codeCssList, CodeWriter codeWriter, GenerationOptions options = null)
        {
            if (codeCssList == null || codeCssList.Count == 0)
            {
                return;
            }

            var enumerator = codeCssList.GetEnumerator();
            var moveNext = enumerator.MoveNext();
            while (moveNext)
            {
                var codeCss = enumerator.Current;
                Generate(codeCss, codeWriter, options);

                moveNext = enumerator.MoveNext();
                if (moveNext)
                {
                    codeWriter.WriteLine();
                }
            }
        }

        /// <summary>
        /// 生成css
        /// </summary>
        public void Generate(CodeCss codeCss, CodeWriter codeWriter, GenerationOptions options = null)
        {
            if (codeCss == null) { return; }
            if (codeWriter == null) { return; }
            options = options ?? new GenerationOptions();

            if (!string.IsNullOrEmpty(codeCss.Summary))
            {
                codeWriter.Write(options.IndentString)
                    .Write(Marks.SLASH).Write(Marks.STAR).Write(Marks.WHITESPACE)
                    .Write(codeCss.Summary)
                    .Write(Marks.WHITESPACE).Write(Marks.STAR).WriteLine(Marks.SLASH);
            }
            codeWriter.Write(options.IndentString).Write(codeCss.Name).Write(Marks.WHITESPACE).WriteLine(Marks.LEFT_BRACE);
            options.PushIndent();

            GenerateCssProperty(codeCss, codeWriter, options);

            options.PopIndent();
            codeWriter.Write(options.IndentString).WriteLine(Marks.RIGHT_BRACE);
        }

        /// <summary>
        /// 生成css 属性
        /// </summary>
        public static void GenerateCssProperty(CodeCss codeCss, CodeWriter codeWriter, GenerationOptions options)
        {
            if (codeCss.PropertyList == null || codeCss.PropertyList.Count == 0)
            {
                return;
            }

            var propertyList = codeCss.PropertyList.OrderBy(v => v.Name).ToList();
            foreach (var property in propertyList)
            {
                if (!string.IsNullOrEmpty(property.Summary))
                {
                    codeWriter.Write(options.IndentString)
                        .Write(Marks.SLASH).Write(Marks.STAR).Write(Marks.WHITESPACE)
                        .Write(property.Summary)
                        .Write(Marks.WHITESPACE).Write(Marks.STAR).WriteLine(Marks.SLASH);
                }

                codeWriter.Write(options.IndentString)
                    .Write(property.Name)
                    .Write(Marks.COLON).Write(Marks.WHITESPACE).Write(property.Value).WriteLine(Marks.SEMICOLON);
            }
        }
    }
}
