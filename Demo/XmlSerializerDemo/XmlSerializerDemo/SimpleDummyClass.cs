using System;
using System.Text;
using System.ComponentModel;
using System.Drawing;
using System.Xml.Serialization;

namespace XmlSerializerDemo
{
  [Serializable]
  [TypeConverter(typeof(GenericTypeConverter<SimpleDummyClass>))]
  public class SimpleDummyClass
  {
    // -------------------------------------------------
    // Comment or uncomment this property after serialization
    // and before deserialization.

    //private string additionalproperty = null;

    //public string AdditionalProperty
    //{
    //  get { return additionalproperty; }
    //  set { additionalproperty = value; }
    //}

    // -------------------------------------------------

    private Color examplecolor;

    public Color ExampleColor
    {
      get { return examplecolor; }
      set { examplecolor = value; }
    }

    private SimpleDummyClass dummyclass = null;

    [XmlIgnore]
    public SimpleDummyClass Dummy
    {
      get { return dummyclass; }
      set { dummyclass = value; }
    }

    private string name = null;

    [DefaultValue("<Unknown>")]
    public string Name
    {
      get { return name; }
      set { name = value; }
    }
    private int age = 0;

    public int Age
    {
      get { return age; }
      set { age = value; }
    }

    public SimpleDummyClass()
    {
    }

    public SimpleDummyClass(string name, int age)
    {
      this.Name = name;
      this.age = age;
    }

    public override string ToString()
    {
      if (String.IsNullOrEmpty(this.Name))
        return "Unnamed SimpleDummy";
      else
        return this.Name;
    }
  }
}
