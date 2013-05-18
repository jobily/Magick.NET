﻿//=================================================================================================
// Copyright 2013 Dirk Lemstra <http://magick.codeplex.com/>
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

namespace Magick.NET.Tests
{
	//==============================================================================================
	[TestClass]
	public class InitializeTests
	{
		//===========================================================================================
		[AssemblyInitialize]
		public static void Initialize(TestContext context)
		{
#if (Q8 && NET20)
			MagickNET.Initialize(@"..\..\..\ImageMagick\Q8\bin\v2.0\x86");
#elif (Q16 && NET20)
			MagickNET.Initialize(@"..\..\..\ImageMagick\Q16\bin\v2.0\x86");
#elif Q8
			MagickNET.Initialize(@"..\..\..\ImageMagick\Q8\bin\v4.0\x86");
#elif Q16
			MagickNET.Initialize(@"..\..\..\ImageMagick\Q16\bin\v4.0\x86");
#else
			Not implemented!
#endif
		}
		//===========================================================================================
	}
	//==============================================================================================
}
