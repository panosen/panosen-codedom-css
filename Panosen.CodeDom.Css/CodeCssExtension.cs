using System;

namespace Panosen.CodeDom.Css
{
    /// <summary>
    /// css 样式
    /// </summary>
    public static class CodeCssExtension
    {

        /// <summary>
        /// set Name
        /// </summary>
        /// <param name="codeCss"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static TCodeCss SetName<TCodeCss>(this TCodeCss codeCss, string name) where TCodeCss : CodeCss
        {
            codeCss.Name = name;

            return codeCss;
        }

        /// <summary>
        /// set Comment
        /// </summary>
        /// <param name="codeCss"></param>
        /// <param name="comment"></param>
        /// <returns></returns>
        public static TCodeCss SetComment<TCodeCss>(this TCodeCss codeCss, string comment) where TCodeCss : CodeCss
        {
            codeCss.Comment = comment;

            return codeCss;
        }


        /// <summary>
        /// set Background
        /// </summary>
        public static TCodeCss SetBackground<TCodeCss>(this TCodeCss codeCss, string @background) where TCodeCss : CodeCss
        {
            codeCss.Background = @background;

            return codeCss;
        }

        /// <summary>
        /// set BackgroundColor
        /// </summary>
        public static TCodeCss SetBackgroundColor<TCodeCss>(this TCodeCss codeCss, string @backgroundColor) where TCodeCss : CodeCss
        {
            codeCss.BackgroundColor = @backgroundColor;

            return codeCss;
        }

        /// <summary>
        /// set Border
        /// </summary>
        public static TCodeCss SetBorder<TCodeCss>(this TCodeCss codeCss, string @border) where TCodeCss : CodeCss
        {
            codeCss.Border = @border;

            return codeCss;
        }

        /// <summary>
        /// set BorderTop
        /// </summary>
        public static TCodeCss SetBorderTop<TCodeCss>(this TCodeCss codeCss, string @borderTop) where TCodeCss : CodeCss
        {
            codeCss.BorderTop = @borderTop;

            return codeCss;
        }

        /// <summary>
        /// set BorderLeft
        /// </summary>
        public static TCodeCss SetBorderLeft<TCodeCss>(this TCodeCss codeCss, string @borderLeft) where TCodeCss : CodeCss
        {
            codeCss.BorderLeft = @borderLeft;

            return codeCss;
        }

        /// <summary>
        /// set BorderRight
        /// </summary>
        public static TCodeCss SetBorderRight<TCodeCss>(this TCodeCss codeCss, string @borderRight) where TCodeCss : CodeCss
        {
            codeCss.BorderRight = @borderRight;

            return codeCss;
        }

        /// <summary>
        /// set BorderBottom
        /// </summary>
        public static TCodeCss SetBorderBottom<TCodeCss>(this TCodeCss codeCss, string @borderBottom) where TCodeCss : CodeCss
        {
            codeCss.BorderBottom = @borderBottom;

            return codeCss;
        }

        /// <summary>
        /// set BorderColor
        /// </summary>
        public static TCodeCss SetBorderColor<TCodeCss>(this TCodeCss codeCss, string @borderColor) where TCodeCss : CodeCss
        {
            codeCss.BorderColor = @borderColor;

            return codeCss;
        }

        /// <summary>
        /// set BorderRadius
        /// </summary>
        public static TCodeCss SetBorderRadius<TCodeCss>(this TCodeCss codeCss, string @borderRadius) where TCodeCss : CodeCss
        {
            codeCss.BorderRadius = @borderRadius;

            return codeCss;
        }

        /// <summary>
        /// set Bottom
        /// </summary>
        public static TCodeCss SetBottom<TCodeCss>(this TCodeCss codeCss, string @bottom) where TCodeCss : CodeCss
        {
            codeCss.Bottom = @bottom;

            return codeCss;
        }

        /// <summary>
        /// set BoxShadow
        /// </summary>
        public static TCodeCss SetBoxShadow<TCodeCss>(this TCodeCss codeCss, string @boxShadow) where TCodeCss : CodeCss
        {
            codeCss.BoxShadow = @boxShadow;

            return codeCss;
        }

        /// <summary>
        /// set Color
        /// </summary>
        public static TCodeCss SetColor<TCodeCss>(this TCodeCss codeCss, string @color) where TCodeCss : CodeCss
        {
            codeCss.Color = @color;

            return codeCss;
        }

        /// <summary>
        /// set Content
        /// </summary>
        public static TCodeCss SetContent<TCodeCss>(this TCodeCss codeCss, string @content) where TCodeCss : CodeCss
        {
            codeCss.Content = @content;

            return codeCss;
        }

        /// <summary>
        /// set Cursor
        /// </summary>
        public static TCodeCss SetCursor<TCodeCss>(this TCodeCss codeCss, string @cursor) where TCodeCss : CodeCss
        {
            codeCss.Cursor = @cursor;

            return codeCss;
        }

        /// <summary>
        /// set Display
        /// </summary>
        public static TCodeCss SetDisplay<TCodeCss>(this TCodeCss codeCss, string @display) where TCodeCss : CodeCss
        {
            codeCss.Display = @display;

            return codeCss;
        }

        /// <summary>
        /// set Float
        /// </summary>
        public static TCodeCss SetFloat<TCodeCss>(this TCodeCss codeCss, string @float) where TCodeCss : CodeCss
        {
            codeCss.Float = @float;

            return codeCss;
        }

        /// <summary>
        /// set Height
        /// </summary>
        public static TCodeCss SetHeight<TCodeCss>(this TCodeCss codeCss, string @height) where TCodeCss : CodeCss
        {
            codeCss.Height = @height;

            return codeCss;
        }

        /// <summary>
        /// set Left
        /// </summary>
        public static TCodeCss SetLeft<TCodeCss>(this TCodeCss codeCss, string @left) where TCodeCss : CodeCss
        {
            codeCss.Left = @left;

            return codeCss;
        }

        /// <summary>
        /// set LineHeight
        /// </summary>
        public static TCodeCss SetLineHeight<TCodeCss>(this TCodeCss codeCss, string @lineHeight) where TCodeCss : CodeCss
        {
            codeCss.LineHeight = @lineHeight;

            return codeCss;
        }

        /// <summary>
        /// set Margin
        /// </summary>
        public static TCodeCss SetMargin<TCodeCss>(this TCodeCss codeCss, string @margin) where TCodeCss : CodeCss
        {
            codeCss.Margin = @margin;

            return codeCss;
        }

        /// <summary>
        /// set MarginBottom
        /// </summary>
        public static TCodeCss SetMarginBottom<TCodeCss>(this TCodeCss codeCss, string @marginBottom) where TCodeCss : CodeCss
        {
            codeCss.MarginBottom = @marginBottom;

            return codeCss;
        }

        /// <summary>
        /// set MarginLeft
        /// </summary>
        public static TCodeCss SetMarginLeft<TCodeCss>(this TCodeCss codeCss, string @marginLeft) where TCodeCss : CodeCss
        {
            codeCss.MarginLeft = @marginLeft;

            return codeCss;
        }

        /// <summary>
        /// set MarginRight
        /// </summary>
        public static TCodeCss SetMarginRight<TCodeCss>(this TCodeCss codeCss, string @marginRight) where TCodeCss : CodeCss
        {
            codeCss.MarginRight = @marginRight;

            return codeCss;
        }

        /// <summary>
        /// set MarginTop
        /// </summary>
        public static TCodeCss SetMarginTop<TCodeCss>(this TCodeCss codeCss, string @marginTop) where TCodeCss : CodeCss
        {
            codeCss.MarginTop = @marginTop;

            return codeCss;
        }

        /// <summary>
        /// set MinHeight
        /// </summary>
        public static TCodeCss SetMinHeight<TCodeCss>(this TCodeCss codeCss, string @minHeight) where TCodeCss : CodeCss
        {
            codeCss.MinHeight = @minHeight;

            return codeCss;
        }

        /// <summary>
        /// set MaxHeight
        /// </summary>
        public static TCodeCss SetMaxHeight<TCodeCss>(this TCodeCss codeCss, string @maxHeight) where TCodeCss : CodeCss
        {
            codeCss.MaxHeight = @maxHeight;

            return codeCss;
        }

        /// <summary>
        /// set Outline
        /// </summary>
        public static TCodeCss SetOutline<TCodeCss>(this TCodeCss codeCss, string @outline) where TCodeCss : CodeCss
        {
            codeCss.Outline = @outline;

            return codeCss;
        }

        /// <summary>
        /// set Padding
        /// </summary>
        public static TCodeCss SetPadding<TCodeCss>(this TCodeCss codeCss, string @padding) where TCodeCss : CodeCss
        {
            codeCss.Padding = @padding;

            return codeCss;
        }

        /// <summary>
        /// set PaddigBottom
        /// </summary>
        public static TCodeCss SetPaddigBottom<TCodeCss>(this TCodeCss codeCss, string @paddigBottom) where TCodeCss : CodeCss
        {
            codeCss.PaddigBottom = @paddigBottom;

            return codeCss;
        }

        /// <summary>
        /// set PaddingLeft
        /// </summary>
        public static TCodeCss SetPaddingLeft<TCodeCss>(this TCodeCss codeCss, string @paddingLeft) where TCodeCss : CodeCss
        {
            codeCss.PaddingLeft = @paddingLeft;

            return codeCss;
        }

        /// <summary>
        /// set PaddingRight
        /// </summary>
        public static TCodeCss SetPaddingRight<TCodeCss>(this TCodeCss codeCss, string @paddingRight) where TCodeCss : CodeCss
        {
            codeCss.PaddingRight = @paddingRight;

            return codeCss;
        }

        /// <summary>
        /// set PaddingTop
        /// </summary>
        public static TCodeCss SetPaddingTop<TCodeCss>(this TCodeCss codeCss, string @paddingTop) where TCodeCss : CodeCss
        {
            codeCss.PaddingTop = @paddingTop;

            return codeCss;
        }

        /// <summary>
        /// set Position
        /// </summary>
        public static TCodeCss SetPosition<TCodeCss>(this TCodeCss codeCss, string @position) where TCodeCss : CodeCss
        {
            codeCss.Position = @position;

            return codeCss;
        }

        /// <summary>
        /// set Right
        /// </summary>
        public static TCodeCss SetRight<TCodeCss>(this TCodeCss codeCss, string @right) where TCodeCss : CodeCss
        {
            codeCss.Right = @right;

            return codeCss;
        }

        /// <summary>
        /// set TextAlign
        /// </summary>
        public static TCodeCss SetTextAlign<TCodeCss>(this TCodeCss codeCss, string @textAlign) where TCodeCss : CodeCss
        {
            codeCss.TextAlign = @textAlign;

            return codeCss;
        }

        /// <summary>
        /// set Top
        /// </summary>
        public static TCodeCss SetTop<TCodeCss>(this TCodeCss codeCss, string @top) where TCodeCss : CodeCss
        {
            codeCss.Top = @top;

            return codeCss;
        }

        /// <summary>
        /// set VerticalAlign
        /// </summary>
        public static TCodeCss SetVerticalAlign<TCodeCss>(this TCodeCss codeCss, string @verticalAlign) where TCodeCss : CodeCss
        {
            codeCss.VerticalAlign = @verticalAlign;

            return codeCss;
        }

        /// <summary>
        /// set Visibility
        /// </summary>
        public static TCodeCss SetVisibility<TCodeCss>(this TCodeCss codeCss, string @visibility) where TCodeCss : CodeCss
        {
            codeCss.Visibility = @visibility;

            return codeCss;
        }

        /// <summary>
        /// set Width
        /// </summary>
        public static TCodeCss SetWidth<TCodeCss>(this TCodeCss codeCss, string @width) where TCodeCss : CodeCss
        {
            codeCss.Width = @width;

            return codeCss;
        }

        /// <summary>
        /// set ZIndex
        /// </summary>
        public static TCodeCss SetZIndex<TCodeCss>(this TCodeCss codeCss, string @zIndex) where TCodeCss : CodeCss
        {
            codeCss.ZIndex = @zIndex;

            return codeCss;
        }
    }
}
