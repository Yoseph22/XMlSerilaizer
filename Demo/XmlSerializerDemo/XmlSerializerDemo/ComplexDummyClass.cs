using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace XmlSerializerDemo
{///////////////////////Changed
  [Serializable]
  public class ComplexDummyClass
  {


      /// <summary>
      /// Second line update from Bekekekeke
      /// </summary>
    /// <summary>
    /// 
    /// </summary>
    private int modified_id = -1;

    public int Modified_id
    {
      get { return modified_id; }
      set { modified_id = value; }
    }
    
     /// <summary>
    /// 
    /// </summary>
    private SimpleDummyClass simpledummy = null;

    public SimpleDummyClass SimpleDummy
    {
      get { return simpledummy; }
      set { simpledummy = value; }
    }


    /// <summary>
    /// Name
    /// </summary>
    private string name = null;

    public string Name
    {
      get { return name; }
      set
      {
        name = value;
        this.Modified_id++;
      }
    }

    /// <summary>
    /// BackColor
    /// </summary>
    private Color examplecolor;

    public Color ExampleColor
    {
      get { return examplecolor; }
      set { examplecolor = value; }
    }

    /// <summary>
    /// Number
    /// </summary>
    private int number = 0;

    public int Number
    {
      get { return number; }
      set
      {
        number = value;
      }
    }

    /// <summary>
    /// DecimalNumber
    /// </summary>
    private Decimal decimalnumber = 0;

    public Decimal DecimalNumber
    {
      get { return decimalnumber; }
      set { decimalnumber = value; }
    }

    /// <summary>
    /// ArrowDirection
    /// </summary>
    private System.Windows.Forms.ArrowDirection arrowdirection = System.Windows.Forms.ArrowDirection.Down;

    public System.Windows.Forms.ArrowDirection ArrowDirection
    {
      get { return arrowdirection; }
      set { arrowdirection = value; }
    }

    /// <summary>
    /// ObjectArray
    /// </summary>
    private object[] objectarray = new object[4];

    public object[] ObjectArray
    {
      get { return objectarray; }
      set { objectarray = value; }
    }

    /// <summary>
    /// Hashtable
    /// </summary>
    private Hashtable hashtable = new Hashtable();

    public Hashtable Hashtable
    {
      get { return hashtable; }
      set { hashtable = value; }
    }

    /// <summary>
    /// SimpleArraylist
    /// </summary>
    private ArrayList arraylist = new ArrayList();

    public ArrayList Arraylist
    {
      get { return arraylist; }
      set { arraylist = value; }
    }
  }
}
