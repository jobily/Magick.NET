﻿//=================================================================================================
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

using ImageMagick;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Magick.NET.Tests
{
  [TestClass]
  public class PsdWriteDefinesTests
  {
    private const string _Category = "PsdWriteDefines";

    private static void CheckProfile(MagickImage image, int expectedLength)
    {
      var profile = image.GetProfile("psd:additional-info");
      int actualLength = profile?.ToByteArray().Length ?? 0;
      Assert.AreEqual(expectedLength, actualLength);
    }

    private static void WriteAndCheckProfile(MagickImageCollection images, PsdWriteDefines defines, int expectedLength)
    {
      using (MemoryStream memStream = new MemoryStream())
      {
        images.Write(memStream, defines);

        memStream.Position = 0;
        images.Read(memStream);
        CheckProfile(images[1], expectedLength);
      }
    }

    [TestMethod, TestCategory(_Category)]
    public void Test_AdditionalInfo()
    {

      using (MagickImageCollection images = new MagickImageCollection())
      {
        images.Read(Files.Coders.LayerStylesSamplePSD);

        CheckProfile(images[1], 264);

        var defines = new PsdWriteDefines()
        {
          AdditionalInfo = PsdAdditionalInfo.All
        };
        WriteAndCheckProfile(images, defines, 264);

        defines.AdditionalInfo = PsdAdditionalInfo.Selective;
        WriteAndCheckProfile(images, defines, 152);

        defines.AdditionalInfo = PsdAdditionalInfo.None;
        WriteAndCheckProfile(images, defines, 0);
      }
    }
  }
}
