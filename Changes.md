# Breaking changes.

### Magick.NET 7.0.1.901:
 - The ExifProfile no longer has a BestPrecision property and uses a Rational and SignedRational struct instead of a double.

### Magick.NET 7.0.1.500:
 - The Shadow method of MagickImage now just creates the shadow. The shadow is no longer drawn behind
   the input image.

### Magick.NET 7.0.1.0:
 - Moved MagickNET.UseOpenCL and SetOpenCLCacheDirectory to the new OpenCL class.
 - Changed MagickGeometry argument of MagickImage.Composite to a PointD.

### Magick.NET 7.0.0.104:
 - Removed Transform methods from MagickImage (use Resize and Crop instead).
 - The Density property of MagickSettings now also uses the Density class.
 - Moved SetDefine/GetDefine/RemoveDefine from MagickImage to the Settings of MagickImage.

### Magick.NET 7.0.0.102:
 - Removed Resolution properties from MagickImage and replaced this with a new Density property.

### Magick.NET 7.0.0.101:
 - Read: [https://magick.codeplex.com/discussions/650746](https://magick.codeplex.com/discussions/650746)

### Magick.NET 7.0.0.022:
  - Renamed MagickImage.AntiAlias to TextAntiAlias.

### Magick.NET 7.0.0.020:
  - The .NET 4.0 build now requires the Visual C++ Redistributable for Visual Studio 2015.

### Magick.NET 7.0.0.018:
  - Cast from double to Percentage is no longer implicit.

### Magick.NET 7.0.0.017:
  - Renamed the values of the FontWeight enumeration.
  - The type of the ClipPaths property of the EightBimProfile has been changed to ClipPath.

### Magick.NET 7.0.0.015:
  - MagickImage.Gamma 'getter' is now a property and Gamma 'setter' has been renamed to GammaCorrect.

### Magick.NET 7.0.0.010:
  - Removed MagickImage.IsMonochrome and added new UseMonochrome property to MagickReadSettings.
  - Reordered arguments for the Distort method.

### Magick.NET 7.0.0.009:
  - Changed type of MagickReadSettings.Density from MagickGeometry to PointD.
  - Removed ReadWarning property and the Read methods no longer return a WarningException. The only way to 
    get warnings is with the Warning event of MagickImage.

### Magick.NET 7.0.0.008:
  - Removed MagickImage.ClipMask property, use Mask instead.
  - Changed type of MagickImage.Density and MagickImage.Resample from MagickGeometry/int to PointD/double.

### Magick.NET 7.0.0.007:
  - Renamed MagickImage.GetOption to GetDefine.

### Magick.NET 7.0.0.003:
  - Renamed MagickImageMoments to Moments.
  - Renamed MagickImageStatistics to Statistics.

### Magick.NET 6.8.9.601:
  - Changed arguments for the Map method of MagickImage.
  - QuantizeSettings uses Riemersma by default.

### Magick.NET 6.8.9.501:
  - Changed arguments for the SparseColor method of MagickImage.

### Magick.NET 6.8.9.101:
  - Int/short Set methods of WritablePixelCollection are now unsigned.
  - The Q16 build no longer uses HDRI, switch to the new Q16-HDRI build if you need HDRI.

### Magick.NET 6.8.8.901:
  - Changed datatype of MagickImage.ColorFuzz to Percentage.

### Magick.NET 6.8.8.801:
  - Fixed double value of Percentage (50% is 50.0 instead of 0.5).
  - Refactored Quantize methods and properties to only one method that use a QuantizeSettings paramater.

### Magick.NET 6.8.8.501:
  - To reduce memory usage the Q8 version of Magick.NET no longer uses HDRI.
  - Removed MagickNET.SetCacheThreshold (Use ResourceLimits).
  - Renamed MagickImage.QuantumOperator to MagickImage.Evaluate.

### Magick.NET 6.8.8.201:
  - Removed MagickImage.ModulusDepth property and moved functionality to BitDepth method.

### Magick.NET 6.8.7.901:
  - Renamed MagickGeometry.Aspect to IgnoreAspectRatio.

### Magick.NET 6.8.7.501:
  - Refactored MagickImageStatistics to prepare for upcoming changes in ImageMagick 7.
  - Renamed MagickImage.SetOption to SetDefine.

### Magick.NET 6.8.7.101:
  - Renamed Matrix classes: MatrixColor = ColorMatrix and MatrixConvolve = ConvolveMatrix.
  - Renamed Depth method with Channels parameter to BitDepth and changed the other method into a property.

### Magick.NET 6.8.7.001:
  - ToBitmap method of MagickImage returns a png instead of a bmp.
  - Changed the value for full transparency from 255(Q8)/65535(Q16) to 0.
  - MagickColor now uses floats instead of Byte/UInt16.

### Magick.NET 6.8.6.801:
  - Renamed Attribute method of MagickImage to GetAttribute and SetAttribute.
  - Renamed Copy method of MagickImage to Clone.
  - Renamed HasMatte attribute to HasAlpha.

### Magick.NET 6.8.6.301:
  - Removed Debug property of MagickImage (use MagickNET.SetLogEvents).
  - MagickImage.Separate no longer modifies the image, it returns an IEnumerable<MagickImage>.
  - LayerMethod enum is no longer public.
  - Removed LayerMethod argument from MagickImageCollection.Merge.

### Magick.NET 6.8.5.1001:
  - MagickNET.Initialize has been made obsolete because the ImageMagick files in the  directory are no longer necessary.
  - MagickGeometry is no longer IDisposable.
  - Renamed dll's so they include the platform name.
  - Image profiles can now only be accessed and modified with ImageProfile classes.
  - Renamed DrawableBase to Drawable.
  - Removed Args part of PathArc/PathCurvetoArgs/PathQuadraticCurvetoArgs classes.

### Magick.NET 6.8.5.401:
  - Renamed ImageType enum to MagickFormat.
  - Renamed ImageType property of MagickImage to Format.
  - Reordered constructor MagickImage(int width, int height, MagickColor color).
  - Replaced Width/Height, ColorSpace with MagickReadSettings object in MagickImage Read methods.
