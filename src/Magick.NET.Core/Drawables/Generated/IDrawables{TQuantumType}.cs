// Copyright 2013-2021 Dirk Lemstra <https://github.com/dlemstra/Magick.NET/>
//
// Licensed under the ImageMagick License (the "License"); you may not use this file except in
// compliance with the License. You may obtain a copy of the License at
//
//   https://www.imagemagick.org/script/license.php
//
// Unless required by applicable law or agreed to in writing, software distributed under the
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
// either express or implied. See the License for the specific language governing permissions
// and limitations under the License.
// <auto-generated/>

using System.Collections.Generic;
using System.Text;

namespace ImageMagick
{
    [System.CodeDom.Compiler.GeneratedCode("Magick.NET.FileGenerator", "")]
    public partial interface IDrawables<TQuantumType>
    {
        /// <summary>
        /// Applies the DrawableAffine operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="scaleX">The X coordinate scaling element.</param>
        /// <param name="scaleY">The Y coordinate scaling element.</param>
        /// <param name="shearX">The X coordinate shearing element.</param>
        /// <param name="shearY">The Y coordinate shearing element.</param>
        /// <param name="translateX">The X coordinate of the translation element.</param>
        /// <param name="translateY">The Y coordinate of the translation element.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> Affine(double scaleX, double scaleY, double shearX, double shearY, double translateX, double translateY);

        /// <summary>
        /// Applies the DrawableAlpha operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="x">The X coordinate.</param>
        /// <param name="y">The Y coordinate.</param>
        /// <param name="paintMethod">The paint method to use.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> Alpha(double x, double y, PaintMethod paintMethod);

        /// <summary>
        /// Applies the DrawableArc operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="startX">The starting X coordinate of the bounding rectangle.</param>
        /// <param name="startY">The starting Y coordinate of thebounding rectangle.</param>
        /// <param name="endX">The ending X coordinate of the bounding rectangle.</param>
        /// <param name="endY">The ending Y coordinate of the bounding rectangle.</param>
        /// <param name="startDegrees">The starting degrees of rotation.</param>
        /// <param name="endDegrees">The ending degrees of rotation.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> Arc(double startX, double startY, double endX, double endY, double startDegrees, double endDegrees);

        /// <summary>
        /// Applies the DrawableBezier operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="coordinates">The coordinates.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> Bezier(params PointD[] coordinates);

        /// <summary>
        /// Applies the DrawableBezier operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="coordinates">The coordinates.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> Bezier(IEnumerable<PointD> coordinates);

        /// <summary>
        /// Applies the DrawableBorderColor operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="color">The color of the border.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> BorderColor(IMagickColor<TQuantumType> color);

        /// <summary>
        /// Applies the DrawableCircle operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="originX">The origin X coordinate.</param>
        /// <param name="originY">The origin Y coordinate.</param>
        /// <param name="perimeterX">The perimeter X coordinate.</param>
        /// <param name="perimeterY">The perimeter Y coordinate.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> Circle(double originX, double originY, double perimeterX, double perimeterY);

        /// <summary>
        /// Applies the DrawableClipPath operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="clipPath">The ID of the clip path.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> ClipPath(string clipPath);

        /// <summary>
        /// Applies the DrawableClipRule operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="fillRule">The rule to use when filling drawn objects.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> ClipRule(FillRule fillRule);

        /// <summary>
        /// Applies the DrawableClipUnits operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="units">The clip path units.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> ClipUnits(ClipPathUnit units);

        /// <summary>
        /// Applies the DrawableColor operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="x">The X coordinate.</param>
        /// <param name="y">The Y coordinate.</param>
        /// <param name="paintMethod">The paint method to use.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> Color(double x, double y, PaintMethod paintMethod);

        /// <summary>
        /// Applies the DrawableComposite operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="offset">The offset from origin.</param>
        /// <param name="image">The image to draw.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> Composite(IMagickGeometry offset, IMagickImage<TQuantumType> image);

        /// <summary>
        /// Applies the DrawableComposite operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="x">The X coordinate.</param>
        /// <param name="y">The Y coordinate.</param>
        /// <param name="image">The image to draw.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> Composite(double x, double y, IMagickImage<TQuantumType> image);

        /// <summary>
        /// Applies the DrawableComposite operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="offset">The offset from origin.</param>
        /// <param name="compose">The algorithm to use.</param>
        /// <param name="image">The image to draw.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> Composite(IMagickGeometry offset, CompositeOperator compose, IMagickImage<TQuantumType> image);

        /// <summary>
        /// Applies the DrawableComposite operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="x">The X coordinate.</param>
        /// <param name="y">The Y coordinate.</param>
        /// <param name="compose">The algorithm to use.</param>
        /// <param name="image">The image to draw.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> Composite(double x, double y, CompositeOperator compose, IMagickImage<TQuantumType> image);

        /// <summary>
        /// Applies the DrawableDensity operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="density">The vertical and horizontal resolution.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> Density(double density);

        /// <summary>
        /// Applies the DrawableDensity operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="pointDensity">The vertical and horizontal resolution.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> Density(PointD pointDensity);

        /// <summary>
        /// Applies the DrawableEllipse operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="originX">The origin X coordinate.</param>
        /// <param name="originY">The origin Y coordinate.</param>
        /// <param name="radiusX">The X radius.</param>
        /// <param name="radiusY">The Y radius.</param>
        /// <param name="startDegrees">The starting degrees of rotation.</param>
        /// <param name="endDegrees">The ending degrees of rotation.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> Ellipse(double originX, double originY, double radiusX, double radiusY, double startDegrees, double endDegrees);

        /// <summary>
        /// Applies the DrawableFillColor operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="color">The color to use.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> FillColor(IMagickColor<TQuantumType> color);

        /// <summary>
        /// Applies the DrawableFillOpacity operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="opacity">The opacity.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> FillOpacity(Percentage opacity);

        /// <summary>
        /// Applies the DrawableFillPatternUrl operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="url">Url specifying pattern ID (e.g. "#pattern_id").</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> FillPatternUrl(string url);

        /// <summary>
        /// Applies the DrawableFillRule operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="fillRule">The rule to use when filling drawn objects.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> FillRule(FillRule fillRule);

        /// <summary>
        /// Applies the DrawableFont operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="family">The font family or the full path to the font file.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> Font(string family);

        /// <summary>
        /// Applies the DrawableFont operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="family">The font family or the full path to the font file.</param>
        /// <param name="style">The style of the font.</param>
        /// <param name="weight">The weight of the font.</param>
        /// <param name="stretch">The font stretching type.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> Font(string family, FontStyleType style, FontWeight weight, FontStretch stretch);

        /// <summary>
        /// Applies the DrawableFontPointSize operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="pointSize">The point size.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> FontPointSize(double pointSize);

        /// <summary>
        /// Applies the DrawableGravity operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="gravity">The gravity.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> Gravity(Gravity gravity);

        /// <summary>
        /// Applies the DrawableLine operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="startX">The starting X coordinate.</param>
        /// <param name="startY">The starting Y coordinate.</param>
        /// <param name="endX">The ending X coordinate.</param>
        /// <param name="endY">The ending Y coordinate.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> Line(double startX, double startY, double endX, double endY);

        /// <summary>
        /// Applies the DrawablePath operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="paths">The paths to use.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> Path(params IPath[] paths);

        /// <summary>
        /// Applies the DrawablePath operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="paths">The paths to use.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> Path(IEnumerable<IPath> paths);

        /// <summary>
        /// Applies the DrawablePoint operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="x">The X coordinate.</param>
        /// <param name="y">The Y coordinate.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> Point(double x, double y);

        /// <summary>
        /// Applies the DrawablePolygon operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="coordinates">The coordinates.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> Polygon(params PointD[] coordinates);

        /// <summary>
        /// Applies the DrawablePolygon operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="coordinates">The coordinates.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> Polygon(IEnumerable<PointD> coordinates);

        /// <summary>
        /// Applies the DrawablePolyline operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="coordinates">The coordinates.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> Polyline(params PointD[] coordinates);

        /// <summary>
        /// Applies the DrawablePolyline operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="coordinates">The coordinates.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> Polyline(IEnumerable<PointD> coordinates);

        /// <summary>
        /// Applies the DrawablePopClipPath operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> PopClipPath();

        /// <summary>
        /// Applies the DrawablePopGraphicContext operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> PopGraphicContext();

        /// <summary>
        /// Applies the DrawablePopPattern operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> PopPattern();

        /// <summary>
        /// Applies the DrawablePushClipPath operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="clipPath">The ID of the clip path.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> PushClipPath(string clipPath);

        /// <summary>
        /// Applies the DrawablePushGraphicContext operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> PushGraphicContext();

        /// <summary>
        /// Applies the DrawablePushPattern operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="id">The ID of the pattern.</param>
        /// <param name="x">The X coordinate.</param>
        /// <param name="y">The Y coordinate.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> PushPattern(string id, double x, double y, double width, double height);

        /// <summary>
        /// Applies the DrawableRectangle operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="upperLeftX">The upper left X coordinate.</param>
        /// <param name="upperLeftY">The upper left Y coordinate.</param>
        /// <param name="lowerRightX">The lower right X coordinate.</param>
        /// <param name="lowerRightY">The lower right Y coordinate.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> Rectangle(double upperLeftX, double upperLeftY, double lowerRightX, double lowerRightY);

        /// <summary>
        /// Applies the DrawableRotation operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="angle">The angle.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> Rotation(double angle);

        /// <summary>
        /// Applies the DrawableRoundRectangle operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="upperLeftX">The upper left X coordinate.</param>
        /// <param name="upperLeftY">The upper left Y coordinate.</param>
        /// <param name="lowerRightX">The lower right X coordinate.</param>
        /// <param name="lowerRightY">The lower right Y coordinate.</param>
        /// <param name="cornerWidth">The corner width.</param>
        /// <param name="cornerHeight">The corner height.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> RoundRectangle(double upperLeftX, double upperLeftY, double lowerRightX, double lowerRightY, double cornerWidth, double cornerHeight);

        /// <summary>
        /// Applies the DrawableScaling operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="x">Horizontal scale factor.</param>
        /// <param name="y">Vertical scale factor.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> Scaling(double x, double y);

        /// <summary>
        /// Applies the DrawableSkewX operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="angle">The angle.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> SkewX(double angle);

        /// <summary>
        /// Applies the DrawableSkewY operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="angle">The angle.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> SkewY(double angle);

        /// <summary>
        /// Applies the DrawableStrokeAntialias operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="isEnabled">True if stroke antialiasing is enabled otherwise false.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> StrokeAntialias(bool isEnabled);

        /// <summary>
        /// Applies the DrawableStrokeColor operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="color">The color to use.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> StrokeColor(IMagickColor<TQuantumType> color);

        /// <summary>
        /// Applies the DrawableStrokeDashArray operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="dash">An array containing the dash information.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> StrokeDashArray(params double[] dash);

        /// <summary>
        /// Applies the DrawableStrokeDashOffset operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="offset">The dash offset.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> StrokeDashOffset(double offset);

        /// <summary>
        /// Applies the DrawableStrokeLineCap operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="lineCap">The line cap.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> StrokeLineCap(LineCap lineCap);

        /// <summary>
        /// Applies the DrawableStrokeLineJoin operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="lineJoin">The line join.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> StrokeLineJoin(LineJoin lineJoin);

        /// <summary>
        /// Applies the DrawableStrokeMiterLimit operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="miterlimit">The miter limit.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> StrokeMiterLimit(int miterlimit);

        /// <summary>
        /// Applies the DrawableStrokeOpacity operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="opacity">The opacity.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> StrokeOpacity(Percentage opacity);

        /// <summary>
        /// Applies the DrawableStrokePatternUrl operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="url">Url specifying pattern ID (e.g. "#pattern_id").</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> StrokePatternUrl(string url);

        /// <summary>
        /// Applies the DrawableStrokeWidth operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> StrokeWidth(double width);

        /// <summary>
        /// Applies the DrawableText operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="x">The X coordinate.</param>
        /// <param name="y">The Y coordinate.</param>
        /// <param name="value">The text to draw.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> Text(double x, double y, string value);

        /// <summary>
        /// Applies the DrawableTextAlignment operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="alignment">Text alignment.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> TextAlignment(TextAlignment alignment);

        /// <summary>
        /// Applies the DrawableTextAntialias operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="isEnabled">True if text antialiasing is enabled otherwise false.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> TextAntialias(bool isEnabled);

        /// <summary>
        /// Applies the DrawableTextDecoration operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="decoration">The text decoration.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> TextDecoration(TextDecoration decoration);

        /// <summary>
        /// Applies the DrawableTextDirection operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="direction">Direction to use.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> TextDirection(TextDirection direction);

        /// <summary>
        /// Applies the DrawableTextEncoding operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="encoding">Encoding to use.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> TextEncoding(Encoding encoding);

        /// <summary>
        /// Applies the DrawableTextInterlineSpacing operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="spacing">Spacing to use.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> TextInterlineSpacing(double spacing);

        /// <summary>
        /// Applies the DrawableTextInterwordSpacing operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="spacing">Spacing to use.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> TextInterwordSpacing(double spacing);

        /// <summary>
        /// Applies the DrawableTextKerning operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="kerning">Kerning to use.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> TextKerning(double kerning);

        /// <summary>
        /// Applies the DrawableTextUnderColor operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="color">The color to use.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> TextUnderColor(IMagickColor<TQuantumType> color);

        /// <summary>
        /// Applies the DrawableTranslation operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="x">The X coordinate.</param>
        /// <param name="y">The Y coordinate.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> Translation(double x, double y);

        /// <summary>
        /// Applies the DrawableViewbox operation to the <see cref="IDrawables{TQuantumType}" />.
        /// </summary>
        /// <param name="upperLeftX">The upper left X coordinate.</param>
        /// <param name="upperLeftY">The upper left Y coordinate.</param>
        /// <param name="lowerRightX">The lower right X coordinate.</param>
        /// <param name="lowerRightY">The lower right Y coordinate.</param>
        /// <returns>The <see cref="IDrawables{TQuantumType}" /> instance.</returns>
        IDrawables<TQuantumType> Viewbox(double upperLeftX, double upperLeftY, double lowerRightX, double lowerRightY);

    }
}
