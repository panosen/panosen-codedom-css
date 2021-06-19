using System;
using System.Collections.Generic;

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
        /// <param name="codeFile"></param>
        /// <param name="codeWriter"></param>
        /// <param name="options"></param>
        public void Generate(CodeCssFile codeFile, CodeWriter codeWriter, GenerationOptions options = null)
        {
            if (codeFile == null) { return; }
            if (codeWriter == null) { return; }
            options = options ?? new GenerationOptions();

            Generate(codeFile.CodeCssList, codeWriter, options);
        }

        /// <summary>
        /// 生成 css 列表
        /// </summary>
        /// <param name="codeCssList"></param>
        /// <param name="codeWriter"></param>
        /// <param name="options"></param>
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
        /// <param name="codeCss"></param>
        /// <param name="codeWriter"></param>
        /// <param name="options"></param>
        public void Generate(CodeCss codeCss, CodeWriter codeWriter, GenerationOptions options = null)
        {
            if (codeCss == null) { return; }
            if (codeWriter == null) { return; }
            options = options ?? new GenerationOptions();

            if (!string.IsNullOrEmpty(codeCss.Comment))
            {
                codeWriter.Write(options.IndentString).Write(Marks.SLASH).Write(Marks.SLASH).WriteLine(codeCss.Comment);
            }
            codeWriter.Write(options.IndentString).Write(codeCss.Name).Write(Marks.WHITESPACE).WriteLine(Marks.LEFT_BRACE);
            options.PushIndent();

            GenerateCssProperty(codeCss, codeWriter, options);

            options.PopIndent();
            codeWriter.Write(options.IndentString).WriteLine(Marks.RIGHT_BRACE);
        }

        private static void GenerateKeyValue(CodeWriter codeWriter, string key, string value, GenerationOptions options)
        {
            if (string.IsNullOrEmpty(value))
            {
                return;
            }

            codeWriter.Write(options.IndentString).Write(key.TrimStart('@')).Write(Marks.COLON).Write(Marks.WHITESPACE).Write(value).WriteLine(Marks.SEMICOLON);
        }
    }
}
