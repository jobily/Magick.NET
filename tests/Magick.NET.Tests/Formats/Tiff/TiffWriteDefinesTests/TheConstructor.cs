﻿// Copyright 2013-2021 Dirk Lemstra <https://github.com/dlemstra/Magick.NET/>
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

using ImageMagick;
using ImageMagick.Formats.Tiff;
using Xunit;

namespace Magick.NET.Tests
{
    public partial class TiffWriteDefinesTests
    {
        public class TheConstructor : TiffWriteDefinesTests
        {
            [Fact]
            public void ShouldNotSetAnyDefine()
            {
                using (var image = new MagickImage())
                {
                    image.Settings.SetDefines(new TiffWriteDefines());

                    Assert.Null(image.Settings.GetDefine(MagickFormat.Tiff, "alpha"));
                    Assert.Null(image.Settings.GetDefine(MagickFormat.Tiff, "endian"));
                    Assert.Null(image.Settings.GetDefine(MagickFormat.Tiff, "fill-order"));
                    Assert.Null(image.Settings.GetDefine(MagickFormat.Tiff, "preserve-compression"));
                    Assert.Null(image.Settings.GetDefine(MagickFormat.Tiff, "rows-per-strip"));
                    Assert.Null(image.Settings.GetDefine(MagickFormat.Tiff, "tile-geometry"));
                    Assert.Null(image.Settings.GetDefine(MagickFormat.Tiff, "write-layers"));
                }
            }
        }
    }
}