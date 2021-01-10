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

namespace ImageMagick
{
    /// <summary>
    /// Class that contains setting for the complex operation.
    /// </summary>
    public sealed class ComplexSettings : IComplexSettings
    {
        /// <summary>
        /// Gets or sets the complex operator.
        /// </summary>
        public ComplexOperator ComplexOperator { get; set; }

        /// <summary>
        /// Gets or sets the signal to noise ratio.
        /// </summary>
        public double? SignalToNoiseRatio { get; set; }
    }
}