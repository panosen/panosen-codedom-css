using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Css
{
    public static partial class CodeCssExtension
    {

        /// <summary>
        /// set align-content
        /// </summary>
        public static TCodeCss SetAlignContent<TCodeCss>(this TCodeCss codeCss, string alignContent)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("align-content", alignContent);

            return codeCss;
        }

        /// <summary>
        /// set align-items
        /// </summary>
        public static TCodeCss SetAlignItems<TCodeCss>(this TCodeCss codeCss, string alignItems)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("align-items", alignItems);

            return codeCss;
        }

        /// <summary>
        /// set align-self
        /// </summary>
        public static TCodeCss SetAlignSelf<TCodeCss>(this TCodeCss codeCss, string alignSelf)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("align-self", alignSelf);

            return codeCss;
        }

        /// <summary>
        /// set all
        /// </summary>
        public static TCodeCss SetAll<TCodeCss>(this TCodeCss codeCss, string all)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("all", all);

            return codeCss;
        }

        /// <summary>
        /// set animation
        /// </summary>
        public static TCodeCss SetAnimation<TCodeCss>(this TCodeCss codeCss, string animation)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("animation", animation);

            return codeCss;
        }

        /// <summary>
        /// set animation-delay
        /// </summary>
        public static TCodeCss SetAnimationDelay<TCodeCss>(this TCodeCss codeCss, string animationDelay)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("animation-delay", animationDelay);

            return codeCss;
        }

        /// <summary>
        /// set animation-direction
        /// </summary>
        public static TCodeCss SetAnimationDirection<TCodeCss>(this TCodeCss codeCss, string animationDirection)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("animation-direction", animationDirection);

            return codeCss;
        }

        /// <summary>
        /// set animation-duration
        /// </summary>
        public static TCodeCss SetAnimationDuration<TCodeCss>(this TCodeCss codeCss, string animationDuration)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("animation-duration", animationDuration);

            return codeCss;
        }

        /// <summary>
        /// set animation-fill-mode
        /// </summary>
        public static TCodeCss SetAnimationFillMode<TCodeCss>(this TCodeCss codeCss, string animationFillMode)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("animation-fill-mode", animationFillMode);

            return codeCss;
        }

        /// <summary>
        /// set animation-iteration-count
        /// </summary>
        public static TCodeCss SetAnimationIterationCount<TCodeCss>(this TCodeCss codeCss, string animationIterationCount)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("animation-iteration-count", animationIterationCount);

            return codeCss;
        }

        /// <summary>
        /// set animation-name
        /// </summary>
        public static TCodeCss SetAnimationName<TCodeCss>(this TCodeCss codeCss, string animationName)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("animation-name", animationName);

            return codeCss;
        }

        /// <summary>
        /// set animation-play-state
        /// </summary>
        public static TCodeCss SetAnimationPlayState<TCodeCss>(this TCodeCss codeCss, string animationPlayState)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("animation-play-state", animationPlayState);

            return codeCss;
        }

        /// <summary>
        /// set animation-timing-function
        /// </summary>
        public static TCodeCss SetAnimationTimingFunction<TCodeCss>(this TCodeCss codeCss, string animationTimingFunction)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("animation-timing-function", animationTimingFunction);

            return codeCss;
        }

        /// <summary>
        /// set backface-visibility
        /// </summary>
        public static TCodeCss SetBackfaceVisibility<TCodeCss>(this TCodeCss codeCss, string backfaceVisibility)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("backface-visibility", backfaceVisibility);

            return codeCss;
        }

        /// <summary>
        /// set background
        /// </summary>
        public static TCodeCss SetBackground<TCodeCss>(this TCodeCss codeCss, string background)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("background", background);

            return codeCss;
        }

        /// <summary>
        /// set background-attachment
        /// </summary>
        public static TCodeCss SetBackgroundAttachment<TCodeCss>(this TCodeCss codeCss, string backgroundAttachment)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("background-attachment", backgroundAttachment);

            return codeCss;
        }

        /// <summary>
        /// set background-blend-mode
        /// </summary>
        public static TCodeCss SetBackgroundBlendMode<TCodeCss>(this TCodeCss codeCss, string backgroundBlendMode)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("background-blend-mode", backgroundBlendMode);

            return codeCss;
        }

        /// <summary>
        /// set background-clip
        /// </summary>
        public static TCodeCss SetBackgroundClip<TCodeCss>(this TCodeCss codeCss, string backgroundClip)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("background-clip", backgroundClip);

            return codeCss;
        }

        /// <summary>
        /// set background-color
        /// </summary>
        public static TCodeCss SetBackgroundColor<TCodeCss>(this TCodeCss codeCss, string backgroundColor)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("background-color", backgroundColor);

            return codeCss;
        }

        /// <summary>
        /// set background-image
        /// </summary>
        public static TCodeCss SetBackgroundImage<TCodeCss>(this TCodeCss codeCss, string backgroundImage)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("background-image", backgroundImage);

            return codeCss;
        }

        /// <summary>
        /// set background-origin
        /// </summary>
        public static TCodeCss SetBackgroundOrigin<TCodeCss>(this TCodeCss codeCss, string backgroundOrigin)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("background-origin", backgroundOrigin);

            return codeCss;
        }

        /// <summary>
        /// set background-position
        /// </summary>
        public static TCodeCss SetBackgroundPosition<TCodeCss>(this TCodeCss codeCss, string backgroundPosition)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("background-position", backgroundPosition);

            return codeCss;
        }

        /// <summary>
        /// set background-repeat
        /// </summary>
        public static TCodeCss SetBackgroundRepeat<TCodeCss>(this TCodeCss codeCss, string backgroundRepeat)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("background-repeat", backgroundRepeat);

            return codeCss;
        }

        /// <summary>
        /// set background-size
        /// </summary>
        public static TCodeCss SetBackgroundSize<TCodeCss>(this TCodeCss codeCss, string backgroundSize)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("background-size", backgroundSize);

            return codeCss;
        }

        /// <summary>
        /// set border
        /// </summary>
        public static TCodeCss SetBorder<TCodeCss>(this TCodeCss codeCss, string border)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("border", border);

            return codeCss;
        }

        /// <summary>
        /// set border-top
        /// </summary>
        public static TCodeCss SetBorderTop<TCodeCss>(this TCodeCss codeCss, string borderTop)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("border-top", borderTop);

            return codeCss;
        }

        /// <summary>
        /// set border-left
        /// </summary>
        public static TCodeCss SetBorderLeft<TCodeCss>(this TCodeCss codeCss, string borderLeft)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("border-left", borderLeft);

            return codeCss;
        }

        /// <summary>
        /// set border-right
        /// </summary>
        public static TCodeCss SetBorderRight<TCodeCss>(this TCodeCss codeCss, string borderRight)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("border-right", borderRight);

            return codeCss;
        }

        /// <summary>
        /// set border-bottom
        /// </summary>
        public static TCodeCss SetBorderBottom<TCodeCss>(this TCodeCss codeCss, string borderBottom)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("border-bottom", borderBottom);

            return codeCss;
        }

        /// <summary>
        /// set border-bottom-color
        /// </summary>
        public static TCodeCss SetBorderBottomColor<TCodeCss>(this TCodeCss codeCss, string borderBottomColor)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("border-bottom-color", borderBottomColor);

            return codeCss;
        }

        /// <summary>
        /// set border-bottom-left-radius
        /// </summary>
        public static TCodeCss SetBorderBottomLeftRadius<TCodeCss>(this TCodeCss codeCss, string borderBottomLeftRadius)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("border-bottom-left-radius", borderBottomLeftRadius);

            return codeCss;
        }

        /// <summary>
        /// set border-bottom-right-radius
        /// </summary>
        public static TCodeCss SetBorderBottomRightRadius<TCodeCss>(this TCodeCss codeCss, string borderBottomRightRadius)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("border-bottom-right-radius", borderBottomRightRadius);

            return codeCss;
        }

        /// <summary>
        /// set border-bottom-style
        /// </summary>
        public static TCodeCss SetBorderBottomStyle<TCodeCss>(this TCodeCss codeCss, string borderBottomStyle)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("border-bottom-style", borderBottomStyle);

            return codeCss;
        }

        /// <summary>
        /// set border-bottom-width
        /// </summary>
        public static TCodeCss SetBorderBottomWidth<TCodeCss>(this TCodeCss codeCss, string borderBottomWidth)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("border-bottom-width", borderBottomWidth);

            return codeCss;
        }

        /// <summary>
        /// set border-collapse
        /// </summary>
        public static TCodeCss SetBorderCollapse<TCodeCss>(this TCodeCss codeCss, string borderCollapse)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("border-collapse", borderCollapse);

            return codeCss;
        }

        /// <summary>
        /// set border-color
        /// </summary>
        public static TCodeCss SetBorderColor<TCodeCss>(this TCodeCss codeCss, string borderColor)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("border-color", borderColor);

            return codeCss;
        }

        /// <summary>
        /// set border-image
        /// </summary>
        public static TCodeCss SetBorderImage<TCodeCss>(this TCodeCss codeCss, string borderImage)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("border-image", borderImage);

            return codeCss;
        }

        /// <summary>
        /// set border-image-outset
        /// </summary>
        public static TCodeCss SetBorderImageOutset<TCodeCss>(this TCodeCss codeCss, string borderImageOutset)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("border-image-outset", borderImageOutset);

            return codeCss;
        }

        /// <summary>
        /// set border-image-repeat
        /// </summary>
        public static TCodeCss SetBorderImageRepeat<TCodeCss>(this TCodeCss codeCss, string borderImageRepeat)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("border-image-repeat", borderImageRepeat);

            return codeCss;
        }

        /// <summary>
        /// set border-image-slice
        /// </summary>
        public static TCodeCss SetBorderImageSlice<TCodeCss>(this TCodeCss codeCss, string borderImageSlice)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("border-image-slice", borderImageSlice);

            return codeCss;
        }

        /// <summary>
        /// set border-image-source
        /// </summary>
        public static TCodeCss SetBorderImageSource<TCodeCss>(this TCodeCss codeCss, string borderImageSource)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("border-image-source", borderImageSource);

            return codeCss;
        }

        /// <summary>
        /// set border-image-width
        /// </summary>
        public static TCodeCss SetBorderImageWidth<TCodeCss>(this TCodeCss codeCss, string borderImageWidth)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("border-image-width", borderImageWidth);

            return codeCss;
        }

        /// <summary>
        /// set border-left-color
        /// </summary>
        public static TCodeCss SetBorderLeftColor<TCodeCss>(this TCodeCss codeCss, string borderLeftColor)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("border-left-color", borderLeftColor);

            return codeCss;
        }

        /// <summary>
        /// set border-left-style
        /// </summary>
        public static TCodeCss SetBorderLeftStyle<TCodeCss>(this TCodeCss codeCss, string borderLeftStyle)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("border-left-style", borderLeftStyle);

            return codeCss;
        }

        /// <summary>
        /// set border-left-width
        /// </summary>
        public static TCodeCss SetBorderLeftWidth<TCodeCss>(this TCodeCss codeCss, string borderLeftWidth)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("border-left-width", borderLeftWidth);

            return codeCss;
        }

        /// <summary>
        /// set border-radius
        /// </summary>
        public static TCodeCss SetBorderRadius<TCodeCss>(this TCodeCss codeCss, string borderRadius)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("border-radius", borderRadius);

            return codeCss;
        }

        /// <summary>
        /// set border-right-color
        /// </summary>
        public static TCodeCss SetBorderRightColor<TCodeCss>(this TCodeCss codeCss, string borderRightColor)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("border-right-color", borderRightColor);

            return codeCss;
        }

        /// <summary>
        /// set border-right-style
        /// </summary>
        public static TCodeCss SetBorderRightStyle<TCodeCss>(this TCodeCss codeCss, string borderRightStyle)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("border-right-style", borderRightStyle);

            return codeCss;
        }

        /// <summary>
        /// set border-right-width
        /// </summary>
        public static TCodeCss SetBorderRightWidth<TCodeCss>(this TCodeCss codeCss, string borderRightWidth)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("border-right-width", borderRightWidth);

            return codeCss;
        }

        /// <summary>
        /// set border-spacing
        /// </summary>
        public static TCodeCss SetBorderSpacing<TCodeCss>(this TCodeCss codeCss, string borderSpacing)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("border-spacing", borderSpacing);

            return codeCss;
        }

        /// <summary>
        /// set border-style
        /// </summary>
        public static TCodeCss SetBorderStyle<TCodeCss>(this TCodeCss codeCss, string borderStyle)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("border-style", borderStyle);

            return codeCss;
        }

        /// <summary>
        /// set border-top-color
        /// </summary>
        public static TCodeCss SetBorderTopColor<TCodeCss>(this TCodeCss codeCss, string borderTopColor)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("border-top-color", borderTopColor);

            return codeCss;
        }

        /// <summary>
        /// set border-top-left-radius
        /// </summary>
        public static TCodeCss SetBorderTopLeftRadius<TCodeCss>(this TCodeCss codeCss, string borderTopLeftRadius)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("border-top-left-radius", borderTopLeftRadius);

            return codeCss;
        }

        /// <summary>
        /// set border-top-right-radius
        /// </summary>
        public static TCodeCss SetBorderTopRightRadius<TCodeCss>(this TCodeCss codeCss, string borderTopRightRadius)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("border-top-right-radius", borderTopRightRadius);

            return codeCss;
        }

        /// <summary>
        /// set border-top-style
        /// </summary>
        public static TCodeCss SetBorderTopStyle<TCodeCss>(this TCodeCss codeCss, string borderTopStyle)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("border-top-style", borderTopStyle);

            return codeCss;
        }

        /// <summary>
        /// set border-top-width
        /// </summary>
        public static TCodeCss SetBorderTopWidth<TCodeCss>(this TCodeCss codeCss, string borderTopWidth)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("border-top-width", borderTopWidth);

            return codeCss;
        }

        /// <summary>
        /// set border-width
        /// </summary>
        public static TCodeCss SetBorderWidth<TCodeCss>(this TCodeCss codeCss, string borderWidth)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("border-width", borderWidth);

            return codeCss;
        }

        /// <summary>
        /// set bottom
        /// </summary>
        public static TCodeCss SetBottom<TCodeCss>(this TCodeCss codeCss, string bottom)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("bottom", bottom);

            return codeCss;
        }

        /// <summary>
        /// set box-decoration-break
        /// </summary>
        public static TCodeCss SetBoxDecorationBreak<TCodeCss>(this TCodeCss codeCss, string boxDecorationBreak)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("box-decoration-break", boxDecorationBreak);

            return codeCss;
        }

        /// <summary>
        /// set box-shadow
        /// </summary>
        public static TCodeCss SetBoxShadow<TCodeCss>(this TCodeCss codeCss, string boxShadow)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("box-shadow", boxShadow);

            return codeCss;
        }

        /// <summary>
        /// set box-sizing
        /// </summary>
        public static TCodeCss SetBoxSizing<TCodeCss>(this TCodeCss codeCss, string boxSizing)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("box-sizing", boxSizing);

            return codeCss;
        }

        /// <summary>
        /// set break-after
        /// </summary>
        public static TCodeCss SetBreakAfter<TCodeCss>(this TCodeCss codeCss, string breakAfter)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("break-after", breakAfter);

            return codeCss;
        }

        /// <summary>
        /// set break-before
        /// </summary>
        public static TCodeCss SetBreakBefore<TCodeCss>(this TCodeCss codeCss, string breakBefore)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("break-before", breakBefore);

            return codeCss;
        }

        /// <summary>
        /// set break-inside
        /// </summary>
        public static TCodeCss SetBreakInside<TCodeCss>(this TCodeCss codeCss, string breakInside)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("break-inside", breakInside);

            return codeCss;
        }

        /// <summary>
        /// set caption-side
        /// </summary>
        public static TCodeCss SetCaptionSide<TCodeCss>(this TCodeCss codeCss, string captionSide)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("caption-side", captionSide);

            return codeCss;
        }

        /// <summary>
        /// set caret-color
        /// </summary>
        public static TCodeCss SetCaretColor<TCodeCss>(this TCodeCss codeCss, string caretColor)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("caret-color", caretColor);

            return codeCss;
        }

        /// <summary>
        /// set @charset
        /// </summary>
        public static TCodeCss SetCharset<TCodeCss>(this TCodeCss codeCss, string charset)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("@charset", charset);

            return codeCss;
        }

        /// <summary>
        /// set clear
        /// </summary>
        public static TCodeCss SetClear<TCodeCss>(this TCodeCss codeCss, string clear)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("clear", clear);

            return codeCss;
        }

        /// <summary>
        /// set clip
        /// </summary>
        public static TCodeCss SetClip<TCodeCss>(this TCodeCss codeCss, string clip)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("clip", clip);

            return codeCss;
        }

        /// <summary>
        /// set color
        /// </summary>
        public static TCodeCss SetColor<TCodeCss>(this TCodeCss codeCss, string color)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("color", color);

            return codeCss;
        }

        /// <summary>
        /// set column-count
        /// </summary>
        public static TCodeCss SetColumnCount<TCodeCss>(this TCodeCss codeCss, string columnCount)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("column-count", columnCount);

            return codeCss;
        }

        /// <summary>
        /// set column-fill
        /// </summary>
        public static TCodeCss SetColumnFill<TCodeCss>(this TCodeCss codeCss, string columnFill)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("column-fill", columnFill);

            return codeCss;
        }

        /// <summary>
        /// set column-gap
        /// </summary>
        public static TCodeCss SetColumnGap<TCodeCss>(this TCodeCss codeCss, string columnGap)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("column-gap", columnGap);

            return codeCss;
        }

        /// <summary>
        /// set column-rule
        /// </summary>
        public static TCodeCss SetColumnRule<TCodeCss>(this TCodeCss codeCss, string columnRule)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("column-rule", columnRule);

            return codeCss;
        }

        /// <summary>
        /// set column-rule-color
        /// </summary>
        public static TCodeCss SetColumnRuleColor<TCodeCss>(this TCodeCss codeCss, string columnRuleColor)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("column-rule-color", columnRuleColor);

            return codeCss;
        }

        /// <summary>
        /// set column-rule-style
        /// </summary>
        public static TCodeCss SetColumnRuleStyle<TCodeCss>(this TCodeCss codeCss, string columnRuleStyle)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("column-rule-style", columnRuleStyle);

            return codeCss;
        }

        /// <summary>
        /// set column-rule-width
        /// </summary>
        public static TCodeCss SetColumnRuleWidth<TCodeCss>(this TCodeCss codeCss, string columnRuleWidth)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("column-rule-width", columnRuleWidth);

            return codeCss;
        }

        /// <summary>
        /// set column-span
        /// </summary>
        public static TCodeCss SetColumnSpan<TCodeCss>(this TCodeCss codeCss, string columnSpan)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("column-span", columnSpan);

            return codeCss;
        }

        /// <summary>
        /// set column-width
        /// </summary>
        public static TCodeCss SetColumnWidth<TCodeCss>(this TCodeCss codeCss, string columnWidth)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("column-width", columnWidth);

            return codeCss;
        }

        /// <summary>
        /// set columns
        /// </summary>
        public static TCodeCss SetColumns<TCodeCss>(this TCodeCss codeCss, string columns)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("columns", columns);

            return codeCss;
        }

        /// <summary>
        /// set content
        /// </summary>
        public static TCodeCss SetContent<TCodeCss>(this TCodeCss codeCss, string content)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("content", content);

            return codeCss;
        }

        /// <summary>
        /// set counter-increment
        /// </summary>
        public static TCodeCss SetCounterIncrement<TCodeCss>(this TCodeCss codeCss, string counterIncrement)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("counter-increment", counterIncrement);

            return codeCss;
        }

        /// <summary>
        /// set counter-reset
        /// </summary>
        public static TCodeCss SetCounterReset<TCodeCss>(this TCodeCss codeCss, string counterReset)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("counter-reset", counterReset);

            return codeCss;
        }

        /// <summary>
        /// set cursor
        /// </summary>
        public static TCodeCss SetCursor<TCodeCss>(this TCodeCss codeCss, string cursor)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("cursor", cursor);

            return codeCss;
        }

        /// <summary>
        /// set direction
        /// </summary>
        public static TCodeCss SetDirection<TCodeCss>(this TCodeCss codeCss, string direction)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("direction", direction);

            return codeCss;
        }

        /// <summary>
        /// set display
        /// </summary>
        public static TCodeCss SetDisplay<TCodeCss>(this TCodeCss codeCss, string display)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("display", display);

            return codeCss;
        }

        /// <summary>
        /// set empty-cells
        /// </summary>
        public static TCodeCss SetEmptyCells<TCodeCss>(this TCodeCss codeCss, string emptyCells)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("empty-cells", emptyCells);

            return codeCss;
        }

        /// <summary>
        /// set filter
        /// </summary>
        public static TCodeCss SetFilter<TCodeCss>(this TCodeCss codeCss, string filter)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("filter", filter);

            return codeCss;
        }

        /// <summary>
        /// set flex
        /// </summary>
        public static TCodeCss SetFlex<TCodeCss>(this TCodeCss codeCss, string flex)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("flex", flex);

            return codeCss;
        }

        /// <summary>
        /// set flex-basis
        /// </summary>
        public static TCodeCss SetFlexBasis<TCodeCss>(this TCodeCss codeCss, string flexBasis)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("flex-basis", flexBasis);

            return codeCss;
        }

        /// <summary>
        /// set flex-direction
        /// </summary>
        public static TCodeCss SetFlexDirection<TCodeCss>(this TCodeCss codeCss, string flexDirection)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("flex-direction", flexDirection);

            return codeCss;
        }

        /// <summary>
        /// set flex-flow
        /// </summary>
        public static TCodeCss SetFlexFlow<TCodeCss>(this TCodeCss codeCss, string flexFlow)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("flex-flow", flexFlow);

            return codeCss;
        }

        /// <summary>
        /// set flex-grow
        /// </summary>
        public static TCodeCss SetFlexGrow<TCodeCss>(this TCodeCss codeCss, string flexGrow)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("flex-grow", flexGrow);

            return codeCss;
        }

        /// <summary>
        /// set flex-shrink
        /// </summary>
        public static TCodeCss SetFlexShrink<TCodeCss>(this TCodeCss codeCss, string flexShrink)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("flex-shrink", flexShrink);

            return codeCss;
        }

        /// <summary>
        /// set flex-wrap
        /// </summary>
        public static TCodeCss SetFlexWrap<TCodeCss>(this TCodeCss codeCss, string flexWrap)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("flex-wrap", flexWrap);

            return codeCss;
        }

        /// <summary>
        /// set @float
        /// </summary>
        public static TCodeCss SetFloat<TCodeCss>(this TCodeCss codeCss, string @float)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("float", @float);

            return codeCss;
        }

        /// <summary>
        /// set font
        /// </summary>
        public static TCodeCss SetFont<TCodeCss>(this TCodeCss codeCss, string font)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("font", font);

            return codeCss;
        }

        /// <summary>
        /// set @font-face
        /// </summary>
        public static TCodeCss SetFontFace<TCodeCss>(this TCodeCss codeCss, string fontFace)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("@font-face", fontFace);

            return codeCss;
        }

        /// <summary>
        /// set font-family
        /// </summary>
        public static TCodeCss SetFontFamily<TCodeCss>(this TCodeCss codeCss, string fontFamily)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("font-family", fontFamily);

            return codeCss;
        }

        /// <summary>
        /// set font-feature-settings
        /// </summary>
        public static TCodeCss SetFontFeatureSettings<TCodeCss>(this TCodeCss codeCss, string fontFeatureSettings)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("font-feature-settings", fontFeatureSettings);

            return codeCss;
        }

        /// <summary>
        /// set @font-feature-values
        /// </summary>
        public static TCodeCss SetFontFeatureValues<TCodeCss>(this TCodeCss codeCss, string fontFeatureValues)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("@font-feature-values", fontFeatureValues);

            return codeCss;
        }

        /// <summary>
        /// set font-kerning
        /// </summary>
        public static TCodeCss SetFontKerning<TCodeCss>(this TCodeCss codeCss, string fontKerning)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("font-kerning", fontKerning);

            return codeCss;
        }

        /// <summary>
        /// set font-language-override
        /// </summary>
        public static TCodeCss SetFontLanguageOverride<TCodeCss>(this TCodeCss codeCss, string fontLanguageOverride)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("font-language-override", fontLanguageOverride);

            return codeCss;
        }

        /// <summary>
        /// set font-size
        /// </summary>
        public static TCodeCss SetFontSize<TCodeCss>(this TCodeCss codeCss, string fontSize)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("font-size", fontSize);

            return codeCss;
        }

        /// <summary>
        /// set font-size-adjust
        /// </summary>
        public static TCodeCss SetFontSizeAdjust<TCodeCss>(this TCodeCss codeCss, string fontSizeAdjust)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("font-size-adjust", fontSizeAdjust);

            return codeCss;
        }

        /// <summary>
        /// set font-stretch
        /// </summary>
        public static TCodeCss SetFontStretch<TCodeCss>(this TCodeCss codeCss, string fontStretch)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("font-stretch", fontStretch);

            return codeCss;
        }

        /// <summary>
        /// set font-style
        /// </summary>
        public static TCodeCss SetFontStyle<TCodeCss>(this TCodeCss codeCss, string fontStyle)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("font-style", fontStyle);

            return codeCss;
        }

        /// <summary>
        /// set font-synthesis
        /// </summary>
        public static TCodeCss SetFontSynthesis<TCodeCss>(this TCodeCss codeCss, string fontSynthesis)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("font-synthesis", fontSynthesis);

            return codeCss;
        }

        /// <summary>
        /// set font-variant
        /// </summary>
        public static TCodeCss SetFontVariant<TCodeCss>(this TCodeCss codeCss, string fontVariant)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("font-variant", fontVariant);

            return codeCss;
        }

        /// <summary>
        /// set font-variant-alternates
        /// </summary>
        public static TCodeCss SetFontVariantAlternates<TCodeCss>(this TCodeCss codeCss, string fontVariantAlternates)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("font-variant-alternates", fontVariantAlternates);

            return codeCss;
        }

        /// <summary>
        /// set font-variant-caps
        /// </summary>
        public static TCodeCss SetFontVariantCaps<TCodeCss>(this TCodeCss codeCss, string fontVariantCaps)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("font-variant-caps", fontVariantCaps);

            return codeCss;
        }

        /// <summary>
        /// set font-variant-east-asian
        /// </summary>
        public static TCodeCss SetFontVariantEastAsian<TCodeCss>(this TCodeCss codeCss, string fontVariantEastAsian)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("font-variant-east-asian", fontVariantEastAsian);

            return codeCss;
        }

        /// <summary>
        /// set font-variant-ligatures
        /// </summary>
        public static TCodeCss SetFontVariantLigatures<TCodeCss>(this TCodeCss codeCss, string fontVariantLigatures)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("font-variant-ligatures", fontVariantLigatures);

            return codeCss;
        }

        /// <summary>
        /// set font-variant-numeric
        /// </summary>
        public static TCodeCss SetFontVariantNumeric<TCodeCss>(this TCodeCss codeCss, string fontVariantNumeric)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("font-variant-numeric", fontVariantNumeric);

            return codeCss;
        }

        /// <summary>
        /// set font-variant-position
        /// </summary>
        public static TCodeCss SetFontVariantPosition<TCodeCss>(this TCodeCss codeCss, string fontVariantPosition)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("font-variant-position", fontVariantPosition);

            return codeCss;
        }

        /// <summary>
        /// set font-weight
        /// </summary>
        public static TCodeCss SetFontWeight<TCodeCss>(this TCodeCss codeCss, string fontWeight)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("font-weight", fontWeight);

            return codeCss;
        }

        /// <summary>
        /// set gap
        /// </summary>
        public static TCodeCss SetGap<TCodeCss>(this TCodeCss codeCss, string gap)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("gap", gap);

            return codeCss;
        }

        /// <summary>
        /// set grid
        /// </summary>
        public static TCodeCss SetGrid<TCodeCss>(this TCodeCss codeCss, string grid)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("grid", grid);

            return codeCss;
        }

        /// <summary>
        /// set grid-area
        /// </summary>
        public static TCodeCss SetGridArea<TCodeCss>(this TCodeCss codeCss, string gridArea)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("grid-area", gridArea);

            return codeCss;
        }

        /// <summary>
        /// set grid-auto-columns
        /// </summary>
        public static TCodeCss SetGridAutoColumns<TCodeCss>(this TCodeCss codeCss, string gridAutoColumns)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("grid-auto-columns", gridAutoColumns);

            return codeCss;
        }

        /// <summary>
        /// set grid-auto-flow
        /// </summary>
        public static TCodeCss SetGridAutoFlow<TCodeCss>(this TCodeCss codeCss, string gridAutoFlow)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("grid-auto-flow", gridAutoFlow);

            return codeCss;
        }

        /// <summary>
        /// set grid-auto-rows
        /// </summary>
        public static TCodeCss SetGridAutoRows<TCodeCss>(this TCodeCss codeCss, string gridAutoRows)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("grid-auto-rows", gridAutoRows);

            return codeCss;
        }

        /// <summary>
        /// set grid-column
        /// </summary>
        public static TCodeCss SetGridColumn<TCodeCss>(this TCodeCss codeCss, string gridColumn)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("grid-column", gridColumn);

            return codeCss;
        }

        /// <summary>
        /// set grid-column-end
        /// </summary>
        public static TCodeCss SetGridColumnEnd<TCodeCss>(this TCodeCss codeCss, string gridColumnEnd)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("grid-column-end", gridColumnEnd);

            return codeCss;
        }

        /// <summary>
        /// set grid-column-gap
        /// </summary>
        public static TCodeCss SetGridColumnGap<TCodeCss>(this TCodeCss codeCss, string gridColumnGap)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("grid-column-gap", gridColumnGap);

            return codeCss;
        }

        /// <summary>
        /// set grid-column-start
        /// </summary>
        public static TCodeCss SetGridColumnStart<TCodeCss>(this TCodeCss codeCss, string gridColumnStart)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("grid-column-start", gridColumnStart);

            return codeCss;
        }

        /// <summary>
        /// set grid-gap
        /// </summary>
        public static TCodeCss SetGridGap<TCodeCss>(this TCodeCss codeCss, string gridGap)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("grid-gap", gridGap);

            return codeCss;
        }

        /// <summary>
        /// set grid-row
        /// </summary>
        public static TCodeCss SetGridRow<TCodeCss>(this TCodeCss codeCss, string gridRow)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("grid-row", gridRow);

            return codeCss;
        }

        /// <summary>
        /// set grid-row-end
        /// </summary>
        public static TCodeCss SetGridRowEnd<TCodeCss>(this TCodeCss codeCss, string gridRowEnd)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("grid-row-end", gridRowEnd);

            return codeCss;
        }

        /// <summary>
        /// set grid-row-gap
        /// </summary>
        public static TCodeCss SetGridRowGap<TCodeCss>(this TCodeCss codeCss, string gridRowGap)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("grid-row-gap", gridRowGap);

            return codeCss;
        }

        /// <summary>
        /// set grid-row-start
        /// </summary>
        public static TCodeCss SetGridRowStart<TCodeCss>(this TCodeCss codeCss, string gridRowStart)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("grid-row-start", gridRowStart);

            return codeCss;
        }

        /// <summary>
        /// set grid-template
        /// </summary>
        public static TCodeCss SetGridTemplate<TCodeCss>(this TCodeCss codeCss, string gridTemplate)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("grid-template", gridTemplate);

            return codeCss;
        }

        /// <summary>
        /// set grid-template-areas
        /// </summary>
        public static TCodeCss SetGridTemplateAreas<TCodeCss>(this TCodeCss codeCss, string gridTemplateAreas)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("grid-template-areas", gridTemplateAreas);

            return codeCss;
        }

        /// <summary>
        /// set grid-template-columns
        /// </summary>
        public static TCodeCss SetGridTemplateColumns<TCodeCss>(this TCodeCss codeCss, string gridTemplateColumns)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("grid-template-columns", gridTemplateColumns);

            return codeCss;
        }

        /// <summary>
        /// set grid-template-rows
        /// </summary>
        public static TCodeCss SetGridTemplateRows<TCodeCss>(this TCodeCss codeCss, string gridTemplateRows)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("grid-template-rows", gridTemplateRows);

            return codeCss;
        }

        /// <summary>
        /// set hanging-punctuation
        /// </summary>
        public static TCodeCss SetHangingPunctuation<TCodeCss>(this TCodeCss codeCss, string hangingPunctuation)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("hanging-punctuation", hangingPunctuation);

            return codeCss;
        }

        /// <summary>
        /// set height
        /// </summary>
        public static TCodeCss SetHeight<TCodeCss>(this TCodeCss codeCss, string height)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("height", height);

            return codeCss;
        }

        /// <summary>
        /// set hyphens
        /// </summary>
        public static TCodeCss SetHyphens<TCodeCss>(this TCodeCss codeCss, string hyphens)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("hyphens", hyphens);

            return codeCss;
        }

        /// <summary>
        /// set image-rendering
        /// </summary>
        public static TCodeCss SetImageRendering<TCodeCss>(this TCodeCss codeCss, string imageRendering)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("image-rendering", imageRendering);

            return codeCss;
        }

        /// <summary>
        /// set @import
        /// </summary>
        public static TCodeCss SetImport<TCodeCss>(this TCodeCss codeCss, string import)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("@import", import);

            return codeCss;
        }

        /// <summary>
        /// set isolation
        /// </summary>
        public static TCodeCss SetIsolation<TCodeCss>(this TCodeCss codeCss, string isolation)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("isolation", isolation);

            return codeCss;
        }

        /// <summary>
        /// set justify-content
        /// </summary>
        public static TCodeCss SetJustifyContent<TCodeCss>(this TCodeCss codeCss, string justifyContent)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("justify-content", justifyContent);

            return codeCss;
        }

        /// <summary>
        /// set @keyframes
        /// </summary>
        public static TCodeCss SetKeyframes<TCodeCss>(this TCodeCss codeCss, string keyframes)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("@keyframes", keyframes);

            return codeCss;
        }

        /// <summary>
        /// set left
        /// </summary>
        public static TCodeCss SetLeft<TCodeCss>(this TCodeCss codeCss, string left)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("left", left);

            return codeCss;
        }

        /// <summary>
        /// set letter-spacing
        /// </summary>
        public static TCodeCss SetLetterSpacing<TCodeCss>(this TCodeCss codeCss, string letterSpacing)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("letter-spacing", letterSpacing);

            return codeCss;
        }

        /// <summary>
        /// set line-break
        /// </summary>
        public static TCodeCss SetLineBreak<TCodeCss>(this TCodeCss codeCss, string lineBreak)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("line-break", lineBreak);

            return codeCss;
        }

        /// <summary>
        /// set line-height
        /// </summary>
        public static TCodeCss SetLineHeight<TCodeCss>(this TCodeCss codeCss, string lineHeight)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("line-height", lineHeight);

            return codeCss;
        }

        /// <summary>
        /// set list-style
        /// </summary>
        public static TCodeCss SetListStyle<TCodeCss>(this TCodeCss codeCss, string listStyle)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("list-style", listStyle);

            return codeCss;
        }

        /// <summary>
        /// set list-style-image
        /// </summary>
        public static TCodeCss SetListStyleImage<TCodeCss>(this TCodeCss codeCss, string listStyleImage)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("list-style-image", listStyleImage);

            return codeCss;
        }

        /// <summary>
        /// set list-style-position
        /// </summary>
        public static TCodeCss SetListStylePosition<TCodeCss>(this TCodeCss codeCss, string listStylePosition)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("list-style-position", listStylePosition);

            return codeCss;
        }

        /// <summary>
        /// set list-style-type
        /// </summary>
        public static TCodeCss SetListStyleType<TCodeCss>(this TCodeCss codeCss, string listStyleType)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("list-style-type", listStyleType);

            return codeCss;
        }

        /// <summary>
        /// set margin
        /// </summary>
        public static TCodeCss SetMargin<TCodeCss>(this TCodeCss codeCss, string margin)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("margin", margin);

            return codeCss;
        }

        /// <summary>
        /// set margin-bottom
        /// </summary>
        public static TCodeCss SetMarginBottom<TCodeCss>(this TCodeCss codeCss, string marginBottom)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("margin-bottom", marginBottom);

            return codeCss;
        }

        /// <summary>
        /// set margin-left
        /// </summary>
        public static TCodeCss SetMarginLeft<TCodeCss>(this TCodeCss codeCss, string marginLeft)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("margin-left", marginLeft);

            return codeCss;
        }

        /// <summary>
        /// set margin-right
        /// </summary>
        public static TCodeCss SetMarginRight<TCodeCss>(this TCodeCss codeCss, string marginRight)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("margin-right", marginRight);

            return codeCss;
        }

        /// <summary>
        /// set margin-top
        /// </summary>
        public static TCodeCss SetMarginTop<TCodeCss>(this TCodeCss codeCss, string marginTop)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("margin-top", marginTop);

            return codeCss;
        }

        /// <summary>
        /// set mask
        /// </summary>
        public static TCodeCss SetMask<TCodeCss>(this TCodeCss codeCss, string mask)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("mask", mask);

            return codeCss;
        }

        /// <summary>
        /// set mask-type
        /// </summary>
        public static TCodeCss SetMaskType<TCodeCss>(this TCodeCss codeCss, string maskType)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("mask-type", maskType);

            return codeCss;
        }

        /// <summary>
        /// set max-width
        /// </summary>
        public static TCodeCss SetMaxWidth<TCodeCss>(this TCodeCss codeCss, string maxWidth)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("max-width", maxWidth);

            return codeCss;
        }

        /// <summary>
        /// set @media
        /// </summary>
        public static TCodeCss SetMedia<TCodeCss>(this TCodeCss codeCss, string media)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("@media", media);

            return codeCss;
        }

        /// <summary>
        /// set min-height
        /// </summary>
        public static TCodeCss SetMinHeight<TCodeCss>(this TCodeCss codeCss, string minHeight)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("min-height", minHeight);

            return codeCss;
        }

        /// <summary>
        /// set max-height
        /// </summary>
        public static TCodeCss SetMaxHeight<TCodeCss>(this TCodeCss codeCss, string maxHeight)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("max-height", maxHeight);

            return codeCss;
        }

        /// <summary>
        /// set min-width
        /// </summary>
        public static TCodeCss SetMinWidth<TCodeCss>(this TCodeCss codeCss, string minWidth)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("min-width", minWidth);

            return codeCss;
        }

        /// <summary>
        /// set mix-blend-mode
        /// </summary>
        public static TCodeCss SetMixBlendMode<TCodeCss>(this TCodeCss codeCss, string mixBlendMode)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("mix-blend-mode", mixBlendMode);

            return codeCss;
        }

        /// <summary>
        /// set object-fit
        /// </summary>
        public static TCodeCss SetObjectFit<TCodeCss>(this TCodeCss codeCss, string objectFit)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("object-fit", objectFit);

            return codeCss;
        }

        /// <summary>
        /// set object-position
        /// </summary>
        public static TCodeCss SetObjectPosition<TCodeCss>(this TCodeCss codeCss, string objectPosition)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("object-position", objectPosition);

            return codeCss;
        }

        /// <summary>
        /// set opacity
        /// </summary>
        public static TCodeCss SetOpacity<TCodeCss>(this TCodeCss codeCss, string opacity)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("opacity", opacity);

            return codeCss;
        }

        /// <summary>
        /// set order
        /// </summary>
        public static TCodeCss SetOrder<TCodeCss>(this TCodeCss codeCss, string order)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("order", order);

            return codeCss;
        }

        /// <summary>
        /// set orphans
        /// </summary>
        public static TCodeCss SetOrphans<TCodeCss>(this TCodeCss codeCss, string orphans)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("orphans", orphans);

            return codeCss;
        }

        /// <summary>
        /// set outline
        /// </summary>
        public static TCodeCss SetOutline<TCodeCss>(this TCodeCss codeCss, string outline)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("outline", outline);

            return codeCss;
        }

        /// <summary>
        /// set outline-color
        /// </summary>
        public static TCodeCss SetOutlineColor<TCodeCss>(this TCodeCss codeCss, string outlineColor)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("outline-color", outlineColor);

            return codeCss;
        }

        /// <summary>
        /// set outline-offset
        /// </summary>
        public static TCodeCss SetOutlineOffset<TCodeCss>(this TCodeCss codeCss, string outlineOffset)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("outline-offset", outlineOffset);

            return codeCss;
        }

        /// <summary>
        /// set outline-style
        /// </summary>
        public static TCodeCss SetOutlineStyle<TCodeCss>(this TCodeCss codeCss, string outlineStyle)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("outline-style", outlineStyle);

            return codeCss;
        }

        /// <summary>
        /// set outline-width
        /// </summary>
        public static TCodeCss SetOutlineWidth<TCodeCss>(this TCodeCss codeCss, string outlineWidth)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("outline-width", outlineWidth);

            return codeCss;
        }

        /// <summary>
        /// set overflow
        /// </summary>
        public static TCodeCss SetOverflow<TCodeCss>(this TCodeCss codeCss, string overflow)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("overflow", overflow);

            return codeCss;
        }

        /// <summary>
        /// set overflow-wrap
        /// </summary>
        public static TCodeCss SetOverflowWrap<TCodeCss>(this TCodeCss codeCss, string overflowWrap)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("overflow-wrap", overflowWrap);

            return codeCss;
        }

        /// <summary>
        /// set overflow-x
        /// </summary>
        public static TCodeCss SetOverflowX<TCodeCss>(this TCodeCss codeCss, string overflowX)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("overflow-x", overflowX);

            return codeCss;
        }

        /// <summary>
        /// set overflow-y
        /// </summary>
        public static TCodeCss SetOverflowY<TCodeCss>(this TCodeCss codeCss, string overflowY)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("overflow-y", overflowY);

            return codeCss;
        }

        /// <summary>
        /// set padding
        /// </summary>
        public static TCodeCss SetPadding<TCodeCss>(this TCodeCss codeCss, string padding)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("padding", padding);

            return codeCss;
        }

        /// <summary>
        /// set padding-bottom
        /// </summary>
        public static TCodeCss SetPaddingBottom<TCodeCss>(this TCodeCss codeCss, string paddingBottom)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("padding-bottom", paddingBottom);

            return codeCss;
        }

        /// <summary>
        /// set padding-left
        /// </summary>
        public static TCodeCss SetPaddingLeft<TCodeCss>(this TCodeCss codeCss, string paddingLeft)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("padding-left", paddingLeft);

            return codeCss;
        }

        /// <summary>
        /// set padding-right
        /// </summary>
        public static TCodeCss SetPaddingRight<TCodeCss>(this TCodeCss codeCss, string paddingRight)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("padding-right", paddingRight);

            return codeCss;
        }

        /// <summary>
        /// set padding-top
        /// </summary>
        public static TCodeCss SetPaddingTop<TCodeCss>(this TCodeCss codeCss, string paddingTop)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("padding-top", paddingTop);

            return codeCss;
        }

        /// <summary>
        /// set page-break-after
        /// </summary>
        public static TCodeCss SetPageBreakAfter<TCodeCss>(this TCodeCss codeCss, string pageBreakAfter)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("page-break-after", pageBreakAfter);

            return codeCss;
        }

        /// <summary>
        /// set page-break-before
        /// </summary>
        public static TCodeCss SetPageBreakBefore<TCodeCss>(this TCodeCss codeCss, string pageBreakBefore)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("page-break-before", pageBreakBefore);

            return codeCss;
        }

        /// <summary>
        /// set page-break-inside
        /// </summary>
        public static TCodeCss SetPageBreakInside<TCodeCss>(this TCodeCss codeCss, string pageBreakInside)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("page-break-inside", pageBreakInside);

            return codeCss;
        }

        /// <summary>
        /// set perspective
        /// </summary>
        public static TCodeCss SetPerspective<TCodeCss>(this TCodeCss codeCss, string perspective)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("perspective", perspective);

            return codeCss;
        }

        /// <summary>
        /// set perspective-origin
        /// </summary>
        public static TCodeCss SetPerspectiveOrigin<TCodeCss>(this TCodeCss codeCss, string perspectiveOrigin)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("perspective-origin", perspectiveOrigin);

            return codeCss;
        }

        /// <summary>
        /// set pointer-events
        /// </summary>
        public static TCodeCss SetPointerEvents<TCodeCss>(this TCodeCss codeCss, string pointerEvents)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("pointer-events", pointerEvents);

            return codeCss;
        }

        /// <summary>
        /// set position
        /// </summary>
        public static TCodeCss SetPosition<TCodeCss>(this TCodeCss codeCss, string position)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("position", position);

            return codeCss;
        }

        /// <summary>
        /// set quotes
        /// </summary>
        public static TCodeCss SetQuotes<TCodeCss>(this TCodeCss codeCss, string quotes)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("quotes", quotes);

            return codeCss;
        }

        /// <summary>
        /// set resize
        /// </summary>
        public static TCodeCss SetResize<TCodeCss>(this TCodeCss codeCss, string resize)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("resize", resize);

            return codeCss;
        }

        /// <summary>
        /// set right
        /// </summary>
        public static TCodeCss SetRight<TCodeCss>(this TCodeCss codeCss, string right)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("right", right);

            return codeCss;
        }

        /// <summary>
        /// set row-gap
        /// </summary>
        public static TCodeCss SetRowGap<TCodeCss>(this TCodeCss codeCss, string rowGap)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("row-gap", rowGap);

            return codeCss;
        }

        /// <summary>
        /// set scroll-behavior
        /// </summary>
        public static TCodeCss SetScrollBehavior<TCodeCss>(this TCodeCss codeCss, string scrollBehavior)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("scroll-behavior", scrollBehavior);

            return codeCss;
        }

        /// <summary>
        /// set tab-size
        /// </summary>
        public static TCodeCss SetTabSize<TCodeCss>(this TCodeCss codeCss, string tabSize)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("tab-size", tabSize);

            return codeCss;
        }

        /// <summary>
        /// set table-layout
        /// </summary>
        public static TCodeCss SetTableLayout<TCodeCss>(this TCodeCss codeCss, string tableLayout)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("table-layout", tableLayout);

            return codeCss;
        }

        /// <summary>
        /// set text-align
        /// </summary>
        public static TCodeCss SetTextAlign<TCodeCss>(this TCodeCss codeCss, string textAlign)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("text-align", textAlign);

            return codeCss;
        }

        /// <summary>
        /// set top
        /// </summary>
        public static TCodeCss SetTop<TCodeCss>(this TCodeCss codeCss, string top)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("top", top);

            return codeCss;
        }

        /// <summary>
        /// set text-align-last
        /// </summary>
        public static TCodeCss SetTextAlignLast<TCodeCss>(this TCodeCss codeCss, string textAlignLast)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("text-align-last", textAlignLast);

            return codeCss;
        }

        /// <summary>
        /// set text-combine-upright
        /// </summary>
        public static TCodeCss SetTextCombineUpright<TCodeCss>(this TCodeCss codeCss, string textCombineUpright)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("text-combine-upright", textCombineUpright);

            return codeCss;
        }

        /// <summary>
        /// set visibility
        /// </summary>
        public static TCodeCss SetVisibility<TCodeCss>(this TCodeCss codeCss, string visibility)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("visibility", visibility);

            return codeCss;
        }

        /// <summary>
        /// set vertical-align
        /// </summary>
        public static TCodeCss SetVerticalAlign<TCodeCss>(this TCodeCss codeCss, string verticalAlign)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("vertical-align", verticalAlign);

            return codeCss;
        }

        /// <summary>
        /// set width
        /// </summary>
        public static TCodeCss SetWidth<TCodeCss>(this TCodeCss codeCss, string width)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("width", width);

            return codeCss;
        }

        /// <summary>
        /// set z-index
        /// </summary>
        public static TCodeCss SetZIndex<TCodeCss>(this TCodeCss codeCss, string zindex)
            where TCodeCss : CodeCss
        {
            codeCss.AddProperty("z-index", zindex);

            return codeCss;
        }

    }
}
