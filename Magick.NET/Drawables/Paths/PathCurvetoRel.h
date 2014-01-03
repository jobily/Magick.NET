//=================================================================================================
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
#pragma once

#include "Args\PathCurveto.h"
#include "Base\PathWrapper.h"

namespace ImageMagick
{
	///=============================================================================================
	///<summary>
	/// Encapsulation of the PathCurvetoRel object.
	///</summary>
	public ref class PathCurvetoRel sealed : PathWrapper<Magick::PathCurvetoRel>
	{
		//===========================================================================================
	public:
		///==========================================================================================
		///<summary>
		/// Initializes a new instance of the PathCurvetoRel class.
		///</summary>
		///<param name="pathCurveto">The coordinate to use.</param>
		PathCurvetoRel(PathCurveto^ pathCurveto);
		///==========================================================================================
		///<summary>
		/// Initializes a new instance of the PathCurvetoRel class.
		///</summary>
		///<param name="pathCurvetos">The coordinates to use.</param>
		PathCurvetoRel(IEnumerable<PathCurveto^>^ pathCurvetos);
		//===========================================================================================
	};
	//==============================================================================================
}