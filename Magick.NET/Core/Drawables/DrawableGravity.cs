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

namespace ImageMagick
{
  /// <summary>
  /// Encapsulation of the DrawableGravity object.
  /// </summary>
  public sealed class DrawableGravity : IDrawable
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="DrawableGravity"/> class.
    /// </summary>
    /// <param name="gravity">The gravity.</param>
    public DrawableGravity(Gravity gravity)
    {
      Gravity = gravity;
    }

    /// <summary>
    /// Gets or sets the gravity.
    /// </summary>
    public Gravity Gravity
    {
      get;
      set;
    }

    /// <summary>
    /// Draws this instance with the drawing wand.
    /// </summary>
    /// <param name="wand">The want to draw on.</param>
    void IDrawable.Draw(IDrawingWand wand)
    {
      if (wand != null)
        wand.Gravity(Gravity);
    }
  }
}