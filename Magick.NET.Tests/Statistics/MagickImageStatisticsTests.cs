﻿//=================================================================================================
// Copyright 2013-2014 Dirk Lemstra <https://magick.codeplex.com/>
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

namespace Magick.NET.Tests
{
	//==============================================================================================
	[TestClass]
	public class MagickImageStatisticsTests
	{
		//===========================================================================================
		private const string _Category = "MagickImageStatistics";
		//===========================================================================================
		[TestMethod, TestCategory(_Category)]
		public void Test_IEquatable()
		{
			MagickImage image = new MagickImage(Files.SnakewarePNG);

			MagickImageStatistics first = image.Statistics();

			Assert.IsFalse(first == null);
			Assert.IsFalse(first.Equals(null));
			Assert.IsTrue(first.Equals(first));
			Assert.IsTrue(first.Equals((object)first));

			MagickImageStatistics second = image.Statistics();

			//Assert.IsTrue(first == second);
			//Assert.IsTrue(first.Equals(second));
			//Assert.IsTrue(first.Equals((object)second));

			image = new MagickImage(Files.MagickNETIconPNG);

			second = image.Statistics();

			Assert.IsTrue(first != second);
			Assert.IsFalse(first.Equals(second));
		}
		//===========================================================================================
	}
	//==============================================================================================
}
