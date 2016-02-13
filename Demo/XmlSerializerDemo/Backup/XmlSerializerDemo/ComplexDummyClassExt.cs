using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace XmlSerializerDemo
{
  /// <summary>
  /// Extends the ComplexDummyClass with a GraphicsPath property.
  /// </summary>
  [Serializable]
  public class ComplexDummyClassExt : ComplexDummyClass
  {
    private GraphicsPath graphicspath = null;

    public GraphicsPath GraphicsPath
    {
      get { return graphicspath; }
      set { graphicspath = value; }
    }
  }
}
