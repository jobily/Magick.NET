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
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using ImageMagick;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Magick.NET.Tests
{
  [TestClass]
  public sealed class XmpProfileTests
  {
    private const string _Category = "XmpProfile";

    private static void TestIXPathNavigable(IXPathNavigable document)
    {
      Assert.IsNotNull(document);

      XPathNavigator navigator = document.CreateNavigator();
      navigator.MoveToRoot();
      Assert.IsTrue(navigator.MoveToChild(XPathNodeType.Element));
      Assert.IsTrue(navigator.MoveToChild(XPathNodeType.Element));
      Assert.IsTrue(navigator.MoveToChild(XPathNodeType.Element));
      int i = 0;
      while (navigator.MoveToNext(XPathNodeType.Element))
        i++;
      Assert.AreEqual(4, i);
    }

#if !(NET20)
    private static void TestXDocument(XDocument document)
    {
      Assert.IsNotNull(document);
      Assert.AreEqual(5, document.Root.Elements().First().Elements().Count());
    }
#endif

    [TestMethod, TestCategory(_Category)]
    public void Test_CreateReader()
    {
      using (MagickImage image = new MagickImage(Files.InvitationTif))
      {
        XmpProfile profile = image.GetXmpProfile();
        Assert.IsNotNull(profile);

        using (XmlReader reader = profile.CreateReader())
        {
          XmlDocument doc = new XmlDocument();
          doc.Load(reader);
          TestIXPathNavigable(doc.CreateNavigator());
        }
      }
    }

    [TestMethod, TestCategory(_Category)]
    public void Test_FromIXPathNavigable()
    {
      using (MagickImage image = new MagickImage(Files.InvitationTif))
      {
        XmpProfile profile = image.GetXmpProfile();
        Assert.IsNotNull(profile);

        IXPathNavigable doc = profile.ToIXPathNavigable();

        ExceptionAssert.Throws<ArgumentNullException>(delegate ()
        {
          XmpProfile.FromIXPathNavigable(null);
        });

        XmpProfile newProfile = XmpProfile.FromIXPathNavigable(doc);
        image.AddProfile(newProfile);

        doc = profile.ToIXPathNavigable();
        TestIXPathNavigable(doc);

        profile = image.GetXmpProfile();
        Assert.IsNotNull(profile);

        doc = profile.ToIXPathNavigable();
        TestIXPathNavigable(doc);

        Assert.AreEqual(profile, newProfile);
      }
    }

#if !(NET20)
    [TestMethod, TestCategory(_Category)]
    public void Test_FromXDocument()
    {
      using (MagickImage image = new MagickImage(Files.InvitationTif))
      {
        XmpProfile profile = image.GetXmpProfile();
        Assert.IsNotNull(profile);

        XDocument doc = profile.ToXDocument();

        ExceptionAssert.Throws<ArgumentNullException>(delegate ()
        {
          XmpProfile.FromXDocument(null);
        });

        XmpProfile newProfile = XmpProfile.FromXDocument(doc);
        image.AddProfile(newProfile);

        doc = profile.ToXDocument();
        TestXDocument(doc);

        profile = image.GetXmpProfile();
        Assert.IsNotNull(profile);

        doc = profile.ToXDocument();
        TestXDocument(doc);

        Assert.AreEqual(profile, newProfile);
      }
    }
#endif

    [TestMethod, TestCategory(_Category)]
    public void Test_ToIXPathNavigable()
    {
      using (MagickImage image = new MagickImage(Files.InvitationTif))
      {
        XmpProfile profile = image.GetXmpProfile();
        Assert.IsNotNull(profile);

        IXPathNavigable doc = profile.ToIXPathNavigable();
        TestIXPathNavigable(doc);
      }
    }

#if !(NET20)
    [TestMethod, TestCategory(_Category)]
    public void Test_ToXDocument()
    {
      using (MagickImage image = new MagickImage(Files.InvitationTif))
      {
        XmpProfile profile = image.GetXmpProfile();
        Assert.IsNotNull(profile);

        XDocument document = profile.ToXDocument();
        TestXDocument(document);
      }
    }
#endif
  }
}
