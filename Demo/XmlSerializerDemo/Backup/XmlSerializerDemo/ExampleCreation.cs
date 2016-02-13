using System;
using System.Collections;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection;

namespace XmlSerializerDemo
{
  public enum ObjectsToBeSerialized
  {
    [Description("SimpleDummyClass")]  
    SimpleDummyClass,
    [Description("SimpleDummyClass with circular references")]
    SimpleDummyClassCircRef,
    [Description("ComplexDummyClass")]  
    ComplexDummyClass,
    [Description("ComplexDummyClass extended with GraphicsPath")]
    ComplexDummyClassExt,
    [Description("String Array with 1.000 items")]  
    StringArray1000,
    [Description("Hashtable (String, SimpleDummyClass) with 1.000 items")]  
    Hashtable1000,
    [Description("From external Assembly")]
    External
  }

  public class ExampleCreation
  {
    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public static Object CreateObject(ObjectsToBeSerialized obj)
    {
      switch (obj)
      {
        case ObjectsToBeSerialized.ComplexDummyClass:
          return CreateComplexDummy();
        case ObjectsToBeSerialized.ComplexDummyClassExt:
          return CreateComplexDummyExt();
        case ObjectsToBeSerialized.Hashtable1000:
          return CreateHashtable(1000);
        case ObjectsToBeSerialized.SimpleDummyClass:
          return CreateSimpleDummyClass(false);
        case ObjectsToBeSerialized.SimpleDummyClassCircRef:
          return CreateSimpleDummyClass(true);
        case ObjectsToBeSerialized.StringArray1000:
          return CreateStringArray(1000);
        case ObjectsToBeSerialized.External:
          return CreateExternalObject();
        default:
          return null;
      }
    }

    /// <summary>
    /// Gets the description of enumeration item.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.Synchronized)]
    public static string GetEnumItemDescription(Enum value)
    {
      FieldInfo fi = value.GetType().GetField(value.ToString());
      DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

      if (attributes.Length > 0)
        return attributes[0].Description;
      else
        return value.ToString();
    }


    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public static object CreateExternalObject()
    {
      Assembly a = Assembly.LoadFrom(@"..\..\DummyExternalAssembly.dll");
      Type t = a.GetType("DummyExternalAssembly.ExternalDummy");

      object obj = Activator.CreateInstance(t);

      return obj;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public static ComplexDummyClass CreateComplexDummy()
    {
      ComplexDummyClass dummy = new ComplexDummyClass();
      SetComplexDummyValues(dummy);

      return dummy;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public static ComplexDummyClassExt CreateComplexDummyExt()
    {
      ComplexDummyClassExt dummy = new ComplexDummyClassExt();
      SetComplexDummyValues(dummy);

      // GraphicsPath
      GraphicsPath gp = new GraphicsPath();
      gp.AddLine(new Point(10, 10), new Point(50, 50));
      gp.AddLine(new Point(50, 75), new Point(30, 75));
      gp.CloseFigure();

      dummy.GraphicsPath = gp;

      return dummy;
    }

    /// <summary>
    /// Sets the properties and values of an ComplexDummyClass.
    /// </summary>
    /// <returns></returns>
    public static void SetComplexDummyValues(ComplexDummyClass dummy)
    {
      dummy.Name = "Marcus";
      dummy.DecimalNumber = (Decimal)12345.7894;
      dummy.Number = 123;
      dummy.ExampleColor = Color.FromArgb(255, 192, 128);
      dummy.ArrowDirection = System.Windows.Forms.ArrowDirection.Right;

      // SimpleDummy
      dummy.SimpleDummy = new SimpleDummyClass("Diggn", 41);
      dummy.SimpleDummy.ExampleColor = Color.Teal;

      SimpleDummyClass sd = new SimpleDummyClass("Yaowi", 36);
      sd.Dummy = new SimpleDummyClass("Dedl", 71);
      sd.Dummy.ExampleColor = Color.Red;
      sd.ExampleColor = Color.Turquoise;

      dummy.SimpleDummy.Dummy = sd;

      // Array
      SimpleDummyClass sd1 = new SimpleDummyClass();
      sd1.Name = "Dieter";
      sd1.Age = 42;
      string[] sarr = new string[] { "er", "sie", "es" };

      dummy.ObjectArray[0] = 125.45;
      dummy.ObjectArray[1] = "Yaowalak";
      dummy.ObjectArray[2] = sarr;
      dummy.ObjectArray[3] = sd1;

      // Hashtable
      SimpleDummyClass sd2 = new SimpleDummyClass();
      sd2.Name = "Hans";
      sd2.Age = 25;

      Hashtable ht = new Hashtable();
      ht.Add("ich", null);
      ht.Add(50, "Margot");
      ht.Add(125.45, 100);
      ht.Add("Peter", 128759364.45);
      ht.Add("Klaus", "Dieter");

      dummy.Hashtable.Add(50, "Marcus");
      dummy.Hashtable.Add("B", Color.AntiqueWhite);
      dummy.Hashtable.Add(12.45, sd2);
      dummy.Hashtable.Add("mytable", ht);

      // ArrayList
      ArrayList al = new ArrayList();
      al.Add("JUMBO");
      al.Add(17);
      al.Add(DateTime.Now);

      dummy.Arraylist.Add("Moin");
      dummy.Arraylist.Add(sd2);
      dummy.Arraylist.Add(1254);
      dummy.Arraylist.Add(al);
    }

    /// <summary>
    /// Creates a Hashtable array for test purposes.
    /// </summary>
    /// <returns></returns>
    public static Hashtable CreateComplexDummyHashtable()
    {
      Hashtable ht = new Hashtable();

      ht.Add("Firstname", "Marcus");
      ht.Add(12, 15.12);

      return ht;
    }

    /// <summary>
    /// Creates an Object array for test purposes.
    /// </summary>
    /// <returns></returns>
    public static object[] CreateComplexDummyObjectArray()
    {
      object[] arr = new object[4];

      arr[0] = "Marcus";
      arr[2] = 45;
      arr[3] = 12.45;

      return arr;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public static SimpleDummyClass CreateSimpleDummyClass(bool circularRef)
    {
      SimpleDummyClass sd = new SimpleDummyClass("Putin", 12);
      sd.ExampleColor = Color.Red;

      // SimpleDummyClass sd2 = new SimpleDummyClass("Bush", 6);
      SimpleDummyClass sd2 = new SimpleDummyClass();
      sd2.Age = 6;
      sd2.ExampleColor = Color.Black;

      // Circular reference?
      if (circularRef)
        sd2.Dummy = sd;

      sd.Dummy = sd2;

      return sd;
    }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="count"></param>
    /// <returns></returns>
    public static string[] CreateStringArray(int count)
    {
      string[] arr = new string[count];

      for (int i = 0; i < arr.Length; i++)
      {
        arr[i] = "Item " + i;
      }

      return arr;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="count"></param>
    /// <returns></returns>
    public static Hashtable CreateHashtable(int count)
    {
      Hashtable ht = new Hashtable();

      for (int i = 0; i < count; i++)
      {
        SimpleDummyClass sd = new SimpleDummyClass("Simple Dummy # " + i, i);
        sd.ExampleColor = Color.Red;
        ht.Add(sd.Name, sd);
      }

      return ht;
    }
  }
}
