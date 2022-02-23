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


        /// <summary>
        /// 生成css 属性
        /// </summary>
        /// <param name="codeCss"></param>
        /// <param name="codeWriter"></param>
        /// <param name="options"></param>
        public static void GenerateCssProperty(CodeCss codeCss, CodeWriter codeWriter, GenerationOptions options)
        {
            GenerateAlignContent(codeWriter, codeCss.AlignContent, options);
            GenerateAlignItems(codeWriter, codeCss.AlignItems, options);
            GenerateAlignSelf(codeWriter, codeCss.AlignSelf, options);
            GenerateAll(codeWriter, codeCss.All, options);
            GenerateAnimation(codeWriter, codeCss.Animation, options);
            GenerateAnimationDelay(codeWriter, codeCss.AnimationDelay, options);
            GenerateAnimationDirection(codeWriter, codeCss.AnimationDirection, options);
            GenerateAnimationDuration(codeWriter, codeCss.AnimationDuration, options);
            GenerateAnimationFillMode(codeWriter, codeCss.AnimationFillMode, options);
            GenerateAnimationIterationCount(codeWriter, codeCss.AnimationIterationCount, options);
            GenerateAnimationName(codeWriter, codeCss.AnimationName, options);
            GenerateAnimationPlayState(codeWriter, codeCss.AnimationPlayState, options);
            GenerateAnimationTimingFunction(codeWriter, codeCss.AnimationTimingFunction, options);
            GenerateBackfaceVisibility(codeWriter, codeCss.BackfaceVisibility, options);
            GenerateBackground(codeWriter, codeCss.Background, options);
            GenerateBackgroundAttachment(codeWriter, codeCss.BackgroundAttachment, options);
            GenerateBackgroundBlendMode(codeWriter, codeCss.BackgroundBlendMode, options);
            GenerateBackgroundClip(codeWriter, codeCss.BackgroundClip, options);
            GenerateBackgroundColor(codeWriter, codeCss.BackgroundColor, options);
            GenerateBackgroundImage(codeWriter, codeCss.BackgroundImage, options);
            GenerateBackgroundOrigin(codeWriter, codeCss.BackgroundOrigin, options);
            GenerateBackgroundPosition(codeWriter, codeCss.BackgroundPosition, options);
            GenerateBackgroundRepeat(codeWriter, codeCss.BackgroundRepeat, options);
            GenerateBackgroundSize(codeWriter, codeCss.BackgroundSize, options);
            GenerateBorder(codeWriter, codeCss.Border, options);
            GenerateBorderBottom(codeWriter, codeCss.BorderBottom, options);
            GenerateBorderBottomColor(codeWriter, codeCss.BorderBottomColor, options);
            GenerateBorderBottomLeftRadius(codeWriter, codeCss.BorderBottomLeftRadius, options);
            GenerateBorderBottomRightRadius(codeWriter, codeCss.BorderBottomRightRadius, options);
            GenerateBorderBottomStyle(codeWriter, codeCss.BorderBottomStyle, options);
            GenerateBorderBottomWidth(codeWriter, codeCss.BorderBottomWidth, options);
            GenerateBorderCollapse(codeWriter, codeCss.BorderCollapse, options);
            GenerateBorderColor(codeWriter, codeCss.BorderColor, options);
            GenerateBorderImage(codeWriter, codeCss.BorderImage, options);
            GenerateBorderImageOutset(codeWriter, codeCss.BorderImageOutset, options);
            GenerateBorderImageRepeat(codeWriter, codeCss.BorderImageRepeat, options);
            GenerateBorderImageSlice(codeWriter, codeCss.BorderImageSlice, options);
            GenerateBorderImageSource(codeWriter, codeCss.BorderImageSource, options);
            GenerateBorderImageWidth(codeWriter, codeCss.BorderImageWidth, options);
            GenerateBorderLeft(codeWriter, codeCss.BorderLeft, options);
            GenerateBorderLeftColor(codeWriter, codeCss.BorderLeftColor, options);
            GenerateBorderLeftStyle(codeWriter, codeCss.BorderLeftStyle, options);
            GenerateBorderLeftWidth(codeWriter, codeCss.BorderLeftWidth, options);
            GenerateBorderRadius(codeWriter, codeCss.BorderRadius, options);
            GenerateBorderRight(codeWriter, codeCss.BorderRight, options);
            GenerateBorderRightColor(codeWriter, codeCss.BorderRightColor, options);
            GenerateBorderRightStyle(codeWriter, codeCss.BorderRightStyle, options);
            GenerateBorderRightWidth(codeWriter, codeCss.BorderRightWidth, options);
            GenerateBorderSpacing(codeWriter, codeCss.BorderSpacing, options);
            GenerateBorderStyle(codeWriter, codeCss.BorderStyle, options);
            GenerateBorderTop(codeWriter, codeCss.BorderTop, options);
            GenerateBorderTopColor(codeWriter, codeCss.BorderTopColor, options);
            GenerateBorderTopLeftRadius(codeWriter, codeCss.BorderTopLeftRadius, options);
            GenerateBorderTopRightRadius(codeWriter, codeCss.BorderTopRightRadius, options);
            GenerateBorderTopStyle(codeWriter, codeCss.BorderTopStyle, options);
            GenerateBorderTopWidth(codeWriter, codeCss.BorderTopWidth, options);
            GenerateBorderWidth(codeWriter, codeCss.BorderWidth, options);
            GenerateBottom(codeWriter, codeCss.Bottom, options);
            GenerateBoxDecorationBreak(codeWriter, codeCss.BoxDecorationBreak, options);
            GenerateBoxShadow(codeWriter, codeCss.BoxShadow, options);
            GenerateBoxSizing(codeWriter, codeCss.BoxSizing, options);
            GenerateBreakAfter(codeWriter, codeCss.BreakAfter, options);
            GenerateBreakBefore(codeWriter, codeCss.BreakBefore, options);
            GenerateBreakInside(codeWriter, codeCss.BreakInside, options);
            GenerateCaptionSide(codeWriter, codeCss.CaptionSide, options);
            GenerateCaretColor(codeWriter, codeCss.CaretColor, options);
            GenerateCharset(codeWriter, codeCss.Charset, options);
            GenerateClear(codeWriter, codeCss.Clear, options);
            GenerateClip(codeWriter, codeCss.Clip, options);
            GenerateColor(codeWriter, codeCss.Color, options);
            GenerateColumnCount(codeWriter, codeCss.ColumnCount, options);
            GenerateColumnFill(codeWriter, codeCss.ColumnFill, options);
            GenerateColumnGap(codeWriter, codeCss.ColumnGap, options);
            GenerateColumnRule(codeWriter, codeCss.ColumnRule, options);
            GenerateColumnRuleColor(codeWriter, codeCss.ColumnRuleColor, options);
            GenerateColumnRuleStyle(codeWriter, codeCss.ColumnRuleStyle, options);
            GenerateColumnRuleWidth(codeWriter, codeCss.ColumnRuleWidth, options);
            GenerateColumns(codeWriter, codeCss.Columns, options);
            GenerateColumnSpan(codeWriter, codeCss.ColumnSpan, options);
            GenerateColumnWidth(codeWriter, codeCss.ColumnWidth, options);
            GenerateContent(codeWriter, codeCss.Content, options);
            GenerateCounterIncrement(codeWriter, codeCss.CounterIncrement, options);
            GenerateCounterReset(codeWriter, codeCss.CounterReset, options);
            GenerateCursor(codeWriter, codeCss.Cursor, options);
            GenerateDirection(codeWriter, codeCss.Direction, options);
            GenerateDisplay(codeWriter, codeCss.Display, options);
            GenerateEmptyCells(codeWriter, codeCss.EmptyCells, options);
            GenerateFilter(codeWriter, codeCss.Filter, options);
            GenerateFlex(codeWriter, codeCss.Flex, options);
            GenerateFlexBasis(codeWriter, codeCss.FlexBasis, options);
            GenerateFlexDirection(codeWriter, codeCss.FlexDirection, options);
            GenerateFlexFlow(codeWriter, codeCss.FlexFlow, options);
            GenerateFlexGrow(codeWriter, codeCss.FlexGrow, options);
            GenerateFlexShrink(codeWriter, codeCss.FlexShrink, options);
            GenerateFlexWrap(codeWriter, codeCss.FlexWrap, options);
            GenerateFloat(codeWriter, codeCss.Float, options);
            GenerateFont(codeWriter, codeCss.Font, options);
            GenerateFontFace(codeWriter, codeCss.FontFace, options);
            GenerateFontFamily(codeWriter, codeCss.FontFamily, options);
            GenerateFontFeatureSettings(codeWriter, codeCss.FontFeatureSettings, options);
            GenerateFontFeatureValues(codeWriter, codeCss.FontFeatureValues, options);
            GenerateFontKerning(codeWriter, codeCss.FontKerning, options);
            GenerateFontLanguageOverride(codeWriter, codeCss.FontLanguageOverride, options);
            GenerateFontSize(codeWriter, codeCss.FontSize, options);
            GenerateFontSizeAdjust(codeWriter, codeCss.FontSizeAdjust, options);
            GenerateFontStretch(codeWriter, codeCss.FontStretch, options);
            GenerateFontStyle(codeWriter, codeCss.FontStyle, options);
            GenerateFontSynthesis(codeWriter, codeCss.FontSynthesis, options);
            GenerateFontVariant(codeWriter, codeCss.FontVariant, options);
            GenerateFontVariantAlternates(codeWriter, codeCss.FontVariantAlternates, options);
            GenerateFontVariantCaps(codeWriter, codeCss.FontVariantCaps, options);
            GenerateFontVariantEastAsian(codeWriter, codeCss.FontVariantEastAsian, options);
            GenerateFontVariantLigatures(codeWriter, codeCss.FontVariantLigatures, options);
            GenerateFontVariantNumeric(codeWriter, codeCss.FontVariantNumeric, options);
            GenerateFontVariantPosition(codeWriter, codeCss.FontVariantPosition, options);
            GenerateFontWeight(codeWriter, codeCss.FontWeight, options);
            GenerateGap(codeWriter, codeCss.Gap, options);
            GenerateGrid(codeWriter, codeCss.Grid, options);
            GenerateGridArea(codeWriter, codeCss.GridArea, options);
            GenerateGridAutoColumns(codeWriter, codeCss.GridAutoColumns, options);
            GenerateGridAutoFlow(codeWriter, codeCss.GridAutoFlow, options);
            GenerateGridAutoRows(codeWriter, codeCss.GridAutoRows, options);
            GenerateGridColumn(codeWriter, codeCss.GridColumn, options);
            GenerateGridColumnEnd(codeWriter, codeCss.GridColumnEnd, options);
            GenerateGridColumnGap(codeWriter, codeCss.GridColumnGap, options);
            GenerateGridColumnStart(codeWriter, codeCss.GridColumnStart, options);
            GenerateGridGap(codeWriter, codeCss.GridGap, options);
            GenerateGridRow(codeWriter, codeCss.GridRow, options);
            GenerateGridRowEnd(codeWriter, codeCss.GridRowEnd, options);
            GenerateGridRowGap(codeWriter, codeCss.GridRowGap, options);
            GenerateGridRowStart(codeWriter, codeCss.GridRowStart, options);
            GenerateGridTemplate(codeWriter, codeCss.GridTemplate, options);
            GenerateGridTemplateAreas(codeWriter, codeCss.GridTemplateAreas, options);
            GenerateGridTemplateColumns(codeWriter, codeCss.GridTemplateColumns, options);
            GenerateGridTemplateRows(codeWriter, codeCss.GridTemplateRows, options);
            GenerateHangingPunctuation(codeWriter, codeCss.HangingPunctuation, options);
            GenerateHeight(codeWriter, codeCss.Height, options);
            GenerateHyphens(codeWriter, codeCss.Hyphens, options);
            GenerateImageRendering(codeWriter, codeCss.ImageRendering, options);
            GenerateImport(codeWriter, codeCss.Import, options);
            GenerateIsolation(codeWriter, codeCss.Isolation, options);
            GenerateJustifyContent(codeWriter, codeCss.JustifyContent, options);
            GenerateKeyframes(codeWriter, codeCss.Keyframes, options);
            GenerateLeft(codeWriter, codeCss.Left, options);
            GenerateLetterSpacing(codeWriter, codeCss.LetterSpacing, options);
            GenerateLineBreak(codeWriter, codeCss.LineBreak, options);
            GenerateLineHeight(codeWriter, codeCss.LineHeight, options);
            GenerateListStyle(codeWriter, codeCss.ListStyle, options);
            GenerateListStyleImage(codeWriter, codeCss.ListStyleImage, options);
            GenerateListStylePosition(codeWriter, codeCss.ListStylePosition, options);
            GenerateListStyleType(codeWriter, codeCss.ListStyleType, options);
            GenerateMargin(codeWriter, codeCss.Margin, options);
            GenerateMarginBottom(codeWriter, codeCss.MarginBottom, options);
            GenerateMarginLeft(codeWriter, codeCss.MarginLeft, options);
            GenerateMarginRight(codeWriter, codeCss.MarginRight, options);
            GenerateMarginTop(codeWriter, codeCss.MarginTop, options);
            GenerateMask(codeWriter, codeCss.Mask, options);
            GenerateMaskType(codeWriter, codeCss.MaskType, options);
            GenerateMaxHeight(codeWriter, codeCss.MaxHeight, options);
            GenerateMaxWidth(codeWriter, codeCss.MaxWidth, options);
            GenerateMedia(codeWriter, codeCss.Media, options);
            GenerateMinHeight(codeWriter, codeCss.MinHeight, options);
            GenerateMinWidth(codeWriter, codeCss.MinWidth, options);
            GenerateMixBlendMode(codeWriter, codeCss.MixBlendMode, options);
            GenerateObjectFit(codeWriter, codeCss.ObjectFit, options);
            GenerateObjectPosition(codeWriter, codeCss.ObjectPosition, options);
            GenerateOpacity(codeWriter, codeCss.Opacity, options);
            GenerateOrder(codeWriter, codeCss.Order, options);
            GenerateOrphans(codeWriter, codeCss.Orphans, options);
            GenerateOutline(codeWriter, codeCss.Outline, options);
            GenerateOutlineColor(codeWriter, codeCss.OutlineColor, options);
            GenerateOutlineOffset(codeWriter, codeCss.OutlineOffset, options);
            GenerateOutlineStyle(codeWriter, codeCss.OutlineStyle, options);
            GenerateOutlineWidth(codeWriter, codeCss.OutlineWidth, options);
            GenerateOverflow(codeWriter, codeCss.Overflow, options);
            GenerateOverflowWrap(codeWriter, codeCss.OverflowWrap, options);
            GenerateOverflowX(codeWriter, codeCss.OverflowX, options);
            GenerateOverflowY(codeWriter, codeCss.OverflowY, options);
            GeneratePadding(codeWriter, codeCss.Padding, options);
            GeneratePaddingBottom(codeWriter, codeCss.PaddingBottom, options);
            GeneratePaddingLeft(codeWriter, codeCss.PaddingLeft, options);
            GeneratePaddingRight(codeWriter, codeCss.PaddingRight, options);
            GeneratePaddingTop(codeWriter, codeCss.PaddingTop, options);
            GeneratePageBreakAfter(codeWriter, codeCss.PageBreakAfter, options);
            GeneratePageBreakBefore(codeWriter, codeCss.PageBreakBefore, options);
            GeneratePageBreakInside(codeWriter, codeCss.PageBreakInside, options);
            GeneratePerspective(codeWriter, codeCss.Perspective, options);
            GeneratePerspectiveOrigin(codeWriter, codeCss.PerspectiveOrigin, options);
            GeneratePointerEvents(codeWriter, codeCss.PointerEvents, options);
            GeneratePosition(codeWriter, codeCss.Position, options);
            GenerateQuotes(codeWriter, codeCss.Quotes, options);
            GenerateResize(codeWriter, codeCss.Resize, options);
            GenerateRight(codeWriter, codeCss.Right, options);
            GenerateRowGap(codeWriter, codeCss.RowGap, options);
            GenerateScrollBehavior(codeWriter, codeCss.ScrollBehavior, options);
            GenerateTableLayout(codeWriter, codeCss.TableLayout, options);
            GenerateTabSize(codeWriter, codeCss.TabSize, options);
            GenerateTextAlign(codeWriter, codeCss.TextAlign, options);
            GenerateTop(codeWriter, codeCss.Top, options);
            GenerateVerticalAlign(codeWriter, codeCss.VerticalAlign, options);
            GenerateTextAlignLast(codeWriter, codeCss.TextAlignLast, options);
            GenerateTextCombineUpright(codeWriter, codeCss.TextCombineUpright, options);
            GenerateVisibility(codeWriter, codeCss.Visibility, options);
            GenerateWidth(codeWriter, codeCss.Width, options);
            GenerateZIndex(codeWriter, codeCss.ZIndex, options);
        }
    }
}
