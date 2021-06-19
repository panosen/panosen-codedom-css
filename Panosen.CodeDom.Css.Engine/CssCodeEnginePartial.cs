using System;
using Panosen.CodeDom;

namespace Panosen.CodeDom.Css.Engine
{
    /// <summary>
    /// css 样式
    /// </summary>
    public partial class CssCodeEngine
    {

        private const string Background = "background";
        private const string BackgroundColor = "background-color";
        private const string Border = "border";
        private const string BorderTop = "border-top";
        private const string BorderLeft = "border-left";
        private const string BorderRight = "border-right";
        private const string BorderBottom = "border-bottom";
        private const string BorderColor = "border-color";
        private const string BorderRadius = "border-radius";
        private const string Bottom = "bottom";
        private const string BoxShadow = "box-shadow";
        private const string Color = "color";
        private const string Content = "content";
        private const string Cursor = "cursor";
        private const string Display = "display";
        private const string Float = "@float";
        private const string Height = "height";
        private const string Left = "left";
        private const string LineHeight = "line-height";
        private const string Margin = "margin";
        private const string MarginBottom = "margin-bottom";
        private const string MarginLeft = "margin-left";
        private const string MarginRight = "margin-right";
        private const string MarginTop = "margin-top";
        private const string MinHeight = "min-height";
        private const string MaxHeight = "max-height";
        private const string Outline = "outline";
        private const string Padding = "padding";
        private const string PaddigBottom = "padding-bottom";
        private const string PaddingLeft = "padding-left";
        private const string PaddingRight = "padding-right";
        private const string PaddingTop = "padding-top";
        private const string Position = "position";
        private const string Right = "right";
        private const string TextAlign = "text-align";
        private const string Top = "top";
        private const string VerticalAlign = "vertical-align";
        private const string Visibility = "visibility";
        private const string Width = "width";
        private const string ZIndex = "z-index";


        /// <summary>
        /// 生成css 属性
        /// </summary>
        /// <param name="codeCss"></param>
        /// <param name="codeWriter"></param>
        /// <param name="options"></param>
        public static void GenerateCssProperty(CodeCss codeCss, CodeWriter codeWriter, GenerationOptions options)
        {
            GenerateKeyValue(codeWriter, Background, codeCss.Background, options);
            GenerateKeyValue(codeWriter, BackgroundColor, codeCss.BackgroundColor, options);
            GenerateKeyValue(codeWriter, Border, codeCss.Border, options);
            GenerateKeyValue(codeWriter, BorderTop, codeCss.BorderTop, options);
            GenerateKeyValue(codeWriter, BorderLeft, codeCss.BorderLeft, options);
            GenerateKeyValue(codeWriter, BorderRight, codeCss.BorderRight, options);
            GenerateKeyValue(codeWriter, BorderBottom, codeCss.BorderBottom, options);
            GenerateKeyValue(codeWriter, BorderColor, codeCss.BorderColor, options);
            GenerateKeyValue(codeWriter, BorderRadius, codeCss.BorderRadius, options);
            GenerateKeyValue(codeWriter, Bottom, codeCss.Bottom, options);
            GenerateKeyValue(codeWriter, BoxShadow, codeCss.BoxShadow, options);
            GenerateKeyValue(codeWriter, Color, codeCss.Color, options);
            GenerateKeyValue(codeWriter, Content, codeCss.Content, options);
            GenerateKeyValue(codeWriter, Cursor, codeCss.Cursor, options);
            GenerateKeyValue(codeWriter, Display, codeCss.Display, options);
            GenerateKeyValue(codeWriter, Float, codeCss.Float, options);
            GenerateKeyValue(codeWriter, Height, codeCss.Height, options);
            GenerateKeyValue(codeWriter, Left, codeCss.Left, options);
            GenerateKeyValue(codeWriter, LineHeight, codeCss.LineHeight, options);
            GenerateKeyValue(codeWriter, Margin, codeCss.Margin, options);
            GenerateKeyValue(codeWriter, MarginBottom, codeCss.MarginBottom, options);
            GenerateKeyValue(codeWriter, MarginLeft, codeCss.MarginLeft, options);
            GenerateKeyValue(codeWriter, MarginRight, codeCss.MarginRight, options);
            GenerateKeyValue(codeWriter, MarginTop, codeCss.MarginTop, options);
            GenerateKeyValue(codeWriter, MinHeight, codeCss.MinHeight, options);
            GenerateKeyValue(codeWriter, MaxHeight, codeCss.MaxHeight, options);
            GenerateKeyValue(codeWriter, Outline, codeCss.Outline, options);
            GenerateKeyValue(codeWriter, Padding, codeCss.Padding, options);
            GenerateKeyValue(codeWriter, PaddigBottom, codeCss.PaddigBottom, options);
            GenerateKeyValue(codeWriter, PaddingLeft, codeCss.PaddingLeft, options);
            GenerateKeyValue(codeWriter, PaddingRight, codeCss.PaddingRight, options);
            GenerateKeyValue(codeWriter, PaddingTop, codeCss.PaddingTop, options);
            GenerateKeyValue(codeWriter, Position, codeCss.Position, options);
            GenerateKeyValue(codeWriter, Right, codeCss.Right, options);
            GenerateKeyValue(codeWriter, TextAlign, codeCss.TextAlign, options);
            GenerateKeyValue(codeWriter, Top, codeCss.Top, options);
            GenerateKeyValue(codeWriter, VerticalAlign, codeCss.VerticalAlign, options);
            GenerateKeyValue(codeWriter, Visibility, codeCss.Visibility, options);
            GenerateKeyValue(codeWriter, Width, codeCss.Width, options);
            GenerateKeyValue(codeWriter, ZIndex, codeCss.ZIndex, options);
        }
    }
}

