//=================================================================================================
// Copyright 2013-2016 Dirk Lemstra <https://magick.codeplex.com/>
//
// Licensed under the ImageMagick License (the "License"); you may not use this file except in
// compliance with the License. You may obtain a copy of the License at
//
//   http://www.imagemagick.org/script/license.php
//
// Unless required by applicable law or agreed to in writing, software distributed under the
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
// express or implied. See the License for the specific language governing permissions and
// limitations under the License.
//=================================================================================================
// <auto-generated/>

using System.Drawing;
using System.Drawing.Drawing2D;

namespace ImageMagick
{
  public sealed partial class Drawables
  {
    /// <summary>
    /// Creates a new DrawableAffine instance using the specified Matrix.
    /// </summary>
    /// <param name="matrix">The matrix.</param>
    public Drawables Affine(Matrix matrix)
    {
      _Drawables.Add(new DrawableAffine(matrix));
      return this;
    }

    /// <summary>
    /// Creates a new DrawableColor instance.
    /// </summary>
    /// <param name="color">The color of the border.</param>
    public Drawables BorderColor(Color color)
    {
      _Drawables.Add(new DrawableBorderColor(color));
      return this;
    }

    /// <summary>
    /// Creates a new DrawableFillColor instance.
    /// </summary>
    /// <param name="color">The color to use.</param>
    public Drawables FillColor(Color color)
    {
      _Drawables.Add(new DrawableFillColor(color));
      return this;
    }

    /// <summary>
    /// Creates a new DrawableRectangle instance.
    /// </summary>
    /// <param name="rectangle">The rectangle to use.</param>
    public Drawables Rectangle(Rectangle rectangle)
    {
      _Drawables.Add(new DrawableRectangle(rectangle));
      return this;
    }

    /// <summary>
    /// Creates a new DrawableStrokeColor instance.
    /// </summary>
    /// <param name="color">The color to use.</param>
    public Drawables StrokeColor(Color color)
    {
      _Drawables.Add(new DrawableStrokeColor(color));
      return this;
    }

    /// <summary>
    /// Creates a new DrawableTextUnderColor instance.
    /// </summary>
    /// <param name="color">The color to use.</param>
    public Drawables TextUnderColor(Color color)
    {
      _Drawables.Add(new DrawableTextUnderColor(color));
      return this;
    }

    /// <summary>
    /// Creates a new DrawableViewbox instance.
    /// </summary>
    /// <param name="rectangle">The rectangle to use.</param>
    public Drawables Viewbox(Rectangle rectangle)
    {
      _Drawables.Add(new DrawableViewbox(rectangle));
      return this;
    }

  }
}
