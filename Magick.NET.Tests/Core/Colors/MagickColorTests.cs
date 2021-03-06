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

using System;
using ImageMagick;
using Microsoft.VisualStudio.TestTools.UnitTesting;

#if Q8
using QuantumType = System.Byte;
#elif Q16
using QuantumType = System.UInt16;
#elif Q16HDRI
using QuantumType = System.Single;
#else
#error Not implemented!
#endif

namespace Magick.NET.Tests
{
  [TestClass]
  public partial class MagickColorTests
  {
    private const string _Category = "MagickColor";

    private void TestColor(string hexValue, double red, double green, double blue, bool isTransparent, double delta)
    {
      MagickColor color = new MagickColor(hexValue);

      Assert.AreEqual(red, color.R, delta);
      Assert.AreEqual(green, color.G, delta);
      Assert.AreEqual(blue, color.B, delta);

      if (isTransparent)
        ColorAssert.IsTransparent(color.A);
      else
        ColorAssert.IsNotTransparent(color.A);
    }

    private void TestColor(string hexValue, double red, double green, double blue, bool isTransparent)
    {
      TestColor(hexValue, red, green, blue, isTransparent, 0.01);
    }

    [TestMethod, TestCategory(_Category)]
    public void Test_IComparable()
    {
      MagickColor first = new MagickColor(MagickColors.White);

      Assert.AreEqual(0, first.CompareTo(first));
      Assert.AreEqual(1, first.CompareTo(null));
      Assert.IsFalse(first < null);
      Assert.IsFalse(first <= null);
      Assert.IsTrue(first > null);
      Assert.IsTrue(first >= null);
      Assert.IsTrue(null < first);
      Assert.IsTrue(null <= first);
      Assert.IsFalse(null > first);
      Assert.IsFalse(null >= first);

      MagickColor second = new MagickColor(MagickColors.Black);

      Assert.AreEqual(1, first.CompareTo(second));
      Assert.IsFalse(first < second);
      Assert.IsFalse(first <= second);
      Assert.IsTrue(first > second);
      Assert.IsTrue(first >= second);

      second = new MagickColor(MagickColors.White);

      Assert.AreEqual(0, first.CompareTo(second));
      Assert.IsFalse(first < second);
      Assert.IsTrue(first <= second);
      Assert.IsFalse(first > second);
      Assert.IsTrue(first >= second);
    }

    [TestMethod, TestCategory(_Category)]
    public void Test_Constructor()
    {
      ExceptionAssert.Throws<ArgumentNullException>(delegate ()
      {
        new MagickColor((string)null);
      });

      ExceptionAssert.Throws<ArgumentException>(delegate ()
      {
        new MagickColor("FFFFFF");
      });

      ExceptionAssert.Throws<ArgumentException>(delegate ()
      {
        new MagickColor("#FFFFF");
      });

      ExceptionAssert.Throws<ArgumentException>(delegate ()
      {
        new MagickColor("#GGFFF");
      });

      TestColor("#FF", Quantum.Max, Quantum.Max, Quantum.Max, false);
      TestColor("#F00", Quantum.Max, 0, 0, false);
      TestColor("#0F00", 0, Quantum.Max, 0, true);
      TestColor("#0000FF", 0, 0, Quantum.Max, false);
      TestColor("#FF00FF00", Quantum.Max, 0, Quantum.Max, true);

      TestColor("#0000FFFF0000", 0, Quantum.Max, 0, false);
      TestColor("#000080000000", 0, (QuantumType)((Quantum.Max / 2.0) + 0.5), 0, false);
      TestColor("#FFFF000000000000", Quantum.Max, 0, 0, true);

      float half = Quantum.Max * 0.5f;
      TestColor("gray(50%) ", half, half, half, false, 1);
      TestColor("rgba(100%, 0%, 0%, 0.0)", Quantum.Max, 0, 0, true);
    }

    [TestMethod, TestCategory(_Category)]
    public void Test_FuzzyEquals()
    {
      MagickColor first = new MagickColor(Quantum.Max, Quantum.Max, Quantum.Max);
      MagickColor second = new MagickColor(Quantum.Max, Quantum.Max, Quantum.Max);

      Assert.IsTrue(first.FuzzyEquals(second, (Percentage)0));

      QuantumType half = (QuantumType)(Quantum.Max / 2.0);
      second = new MagickColor(Quantum.Max, half, Quantum.Max);

      Assert.IsFalse(first.FuzzyEquals(second, (Percentage)0));
      Assert.IsFalse(first.FuzzyEquals(second, (Percentage)10));
      Assert.IsFalse(first.FuzzyEquals(second, (Percentage)20));
      Assert.IsTrue(first.FuzzyEquals(second, (Percentage)30));
    }

    [TestMethod, TestCategory(_Category)]
    public void Test_IEquatable()
    {
      MagickColor first = new MagickColor(MagickColors.Red);

      Assert.IsFalse(first == null);
      Assert.IsFalse(first.Equals(null));
      Assert.IsTrue(first.Equals(first));
      Assert.IsTrue(first.Equals((object)first));

      MagickColor second = new MagickColor(Quantum.Max, 0, 0);

      Assert.IsTrue(first == second);
      Assert.IsTrue(first.Equals(second));
      Assert.IsTrue(first.Equals((object)second));

      second = new MagickColor(MagickColors.Green);

      Assert.IsTrue(first != second);
      Assert.IsFalse(first.Equals(second));
    }

    [TestMethod, TestCategory(_Category)]
    public void Test_ToColor()
    {
      MagickColor color = new MagickColor(MagickColors.Red);
      Assert.AreEqual(Quantum.Max, color.A);

      ColorAssert.AreEqual(MagickColors.Red, color);
    }

    [TestMethod, TestCategory(_Category)]
    public void Test_ToString()
    {
      MagickColor color = new MagickColor(MagickColors.Red);
#if Q8
      Assert.AreEqual("#FF0000FF", color.ToString());
#elif Q16 || Q16HDRI
      Assert.AreEqual("#FFFF00000000FFFF", color.ToString());
#else
#error Not implemented!
#endif

#if Q8
      color = new MagickColor(0, Quantum.Max, 0, 0, (System.Byte)(Quantum.Max / 3));
#elif Q16
      color = new MagickColor(0, Quantum.Max, 0, 0, (System.UInt16)(Quantum.Max / 3));
#elif Q16HDRI
      color = new MagickColor(0, Quantum.Max, 0, 0, (System.Single)(Quantum.Max / 3));
#else
#error Not implemented!
#endif
      Assert.AreEqual("cmyka(0," + Quantum.Max + ",0,0,0.3333)", color.ToString());

      color = new MagickColor(0, Quantum.Max, 0, 0, Quantum.Max);
      Assert.AreEqual("cmyka(0," + Quantum.Max + ",0,0,1.0)", color.ToString());
    }
  }
}
