using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Runtime.Serialization.Formatters.Soap;
using SYSTEMXML = System.Xml.Serialization;
using Yaowi.Common.Serialization;

namespace XmlSerializerDemo
{
  public partial class Form1 : Form
  {
    // The XmlSerializer as member so its properties can be set in the PropertyGrid on the TabControl
    private XmlSerializer xmlserializer = new XmlSerializer();

    public Form1()
    {
      InitializeComponent();
    }

    #region Serialize / Deserialize

    /// <summary>
    /// 
    /// </summary>
    private void DeepXmlSerializer_Serialize()
    {
      if (this.propertyGrid1.SelectedObject == null)
      {
        MessageBox.Show("No object selected!");
        return;
      }

      this.saveFileDialog1.DefaultExt = "xml";
      this.saveFileDialog1.Filter = "XML|*.xml|All files|*.*";

      if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
      {
        string filename = this.saveFileDialog1.FileName;

        if (this.checkBoxIgnoreAttribute.Checked)
          this.xmlserializer.SerializationIgnoredAttributeType = typeof(SYSTEMXML.XmlIgnoreAttribute);
        else
          this.xmlserializer.SerializationIgnoredAttributeType = null;

        this.xmlserializer.Serialize(this.propertyGrid1.SelectedObject, filename);
      }
    }

    /// <summary>
    /// 
    /// </summary>
    private void DeepXmlSerializer_Deserialize()
    {
      try
      {
        this.openFileDialog1.DefaultExt = "xml";
        this.openFileDialog1.Filter = "XML|*.xml|All files|*.*";

        if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
        {
          string filename = this.openFileDialog1.FileName;

          using (XmlDeserializer xd = new XmlDeserializer())
          {
            // Load an external assembly and register it to instantiate an ExternalDummy instance.
            // This could be a PlugIn.
            DirectoryInfo dir = new DirectoryInfo(Application.StartupPath);
            dir = dir.Parent.Parent;
            Assembly a = Assembly.LoadFrom(dir.FullName + @"\DummyExternalAssembly.dll");

            xd.RegisterAssembly(a);

            //xd.IgnoreCreationErrors = true; // Default is false
            Object obj = xd.Deserialize(filename);
            this.propertyGrid1.SelectedObject = obj;

          }
        }
      }
      catch (Exception exc)
      {
        HandleException(exc);
      }
    }

    /// <summary>
    /// 
    /// </summary>
    private void XmlSerializer_Serialize()
    {
      try
      {
        if (this.propertyGrid1.SelectedObject == null)
        {
          MessageBox.Show("No object selected!");
          return;
        }

        this.saveFileDialog1.DefaultExt = "xml";
        this.saveFileDialog1.Filter = "XML|*.xml|All files|*.*";

        if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
        {
          string filename = this.saveFileDialog1.FileName;

          SYSTEMXML.XmlSerializer serializer = new SYSTEMXML.XmlSerializer(this.propertyGrid1.SelectedObject.GetType());

          FileStream fs = new FileStream(filename, FileMode.Create);
          TextWriter writer = new StreamWriter(fs, new UTF8Encoding());
          serializer.Serialize(writer, this.propertyGrid1.SelectedObject);
          writer.Close();
        }
      }
      catch (Exception exc)
      {
        HandleException(exc);
      }
    }

    /// <summary>
    /// 
    /// </summary>
    private void XmlSerializer_Deserialize()
    {
      try
      {
        this.openFileDialog1.DefaultExt = "xml";
        this.openFileDialog1.Filter = "XML|*.xml|All files|*.*";

        if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
        {
          string filename = this.openFileDialog1.FileName;

          SYSTEMXML.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(SimpleDummyClass));

          FileStream fs = new FileStream(filename, FileMode.OpenOrCreate);
          TextReader reader = new StreamReader(fs);
          this.propertyGrid1.SelectedObject = serializer.Deserialize(reader);
        }
      }
      catch (Exception exc)
      {
        HandleException(exc);
      }
    }

    /// <summary>
    /// 
    /// </summary>
    private void BinaryFormatter_Serialize()
    {
      try
      {
        if (this.propertyGrid1.SelectedObject == null)
        {
          MessageBox.Show("No object selected!");
          return;
        }

        this.saveFileDialog1.DefaultExt = "dat";
        this.saveFileDialog1.Filter = "Binary file|*.dat|All files|*.*";

        if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
        {
          string filename = this.saveFileDialog1.FileName;

          FileStream fs = new FileStream(filename, FileMode.Create);

          BinaryFormatter formatter = new BinaryFormatter();
          formatter.Serialize(fs, this.propertyGrid1.SelectedObject);
          fs.Flush();
          fs.Close();
        }
      }
      catch (Exception exc)
      {
        HandleException(exc);
      }
    }

    /// <summary>
    /// 
    /// </summary>
    private void BinaryFormatter_Deserialize()
    {
      try
      {
        this.openFileDialog1.DefaultExt = "dat";
        this.openFileDialog1.Filter = "Binary files|*.dat|All files|*.*";

        if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
        {
          string filename = this.openFileDialog1.FileName;

          FileStream fs = new FileStream(filename, FileMode.Open);

          BinaryFormatter formatter = new BinaryFormatter();
          this.propertyGrid1.SelectedObject = formatter.Deserialize(fs);
          fs.Close();
        }
      }
      catch (Exception exc)
      {
        HandleException(exc);
      }
    }

    /// <summary>
    /// 
    /// </summary>
    private void SoapFormatter_Serialize()
    {
      FileStream fs = null;

      try
      {
        if (this.propertyGrid1.SelectedObject == null)
        {
          MessageBox.Show("No object selected!");
          return;
        }

        this.saveFileDialog1.DefaultExt = "xml";
        this.saveFileDialog1.Filter = "XML|*.xml|All files|*.*";

        if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
        {
          string filename = this.saveFileDialog1.FileName;

          fs = new FileStream(filename, FileMode.Create);
          SoapFormatter formatter = new SoapFormatter();
          formatter.Serialize(fs, this.propertyGrid1.SelectedObject);
        }
      }
      catch (Exception exc)
      {
        HandleException(exc);
      }
      finally
      {
        if (fs != null)
          fs.Close();
      }
    }

    /// <summary>
    /// 
    /// </summary>
    private void SoapFormatter_Deserialize()
    {
      this.openFileDialog1.DefaultExt = "xml";
      this.openFileDialog1.Filter = "XML|*.xml|All files|*.*";

      FileStream fs = null;

      try
      {
        if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
        {
          string filename = this.openFileDialog1.FileName;

          fs = new FileStream(filename, FileMode.Open);
          SoapFormatter formatter = new SoapFormatter();

          this.propertyGrid1.SelectedObject = formatter.Deserialize(fs);
        }
      }
      catch (Exception exc)
      {
        HandleException(exc);
      }
      finally
      {
        if (fs != null)
          fs.Close();
      }
    }

    #endregion Serialize / Deserialize

    #region Helpers

    /// <summary>
    /// 
    /// </summary>
    /// <param name="exc"></param>
    private void HandleException(Exception exc)
    {
      string msg = null;

      msg = exc.Source + "\n";

      if (exc.InnerException != null)
        msg = exc.Message + "\n\nInner Exception:\n" + exc.InnerException.Message;
      else
        msg = exc.Message;

      Console.WriteLine("ERROR!\n" + msg);

      MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private void AddExample(ObjectsToBeSerialized obtbs)
    {
      ListViewItem li = new ListViewItem(ExampleCreation.GetEnumItemDescription(obtbs));
      li.ImageIndex = 0;
      li.Tag = obtbs;
      this.listView1.Items.Add(li);
    }

    #endregion Helpers

    #region Events

    private void Form1_Load(object sender, EventArgs e)
    {
      AddExample(ObjectsToBeSerialized.SimpleDummyClass);
      AddExample(ObjectsToBeSerialized.SimpleDummyClassCircRef);
      AddExample(ObjectsToBeSerialized.ComplexDummyClass);
      AddExample(ObjectsToBeSerialized.ComplexDummyClassExt);
      AddExample(ObjectsToBeSerialized.StringArray1000);
      AddExample(ObjectsToBeSerialized.Hashtable1000);
      AddExample(ObjectsToBeSerialized.External);

      if(xmlserializer==null)
        xmlserializer = new XmlSerializer();

      this.propertyGrid2.SelectedObject = xmlserializer;
    }

    private void btnClearGrid_Click(object sender, EventArgs e)
    {
      this.propertyGrid1.SelectedObject = null;
    }

    private void listView1_DoubleClick(object sender, EventArgs e)
    {
      if (this.listView1.SelectedItems.Count > 0)
      {
        ObjectsToBeSerialized en = (ObjectsToBeSerialized)this.listView1.SelectedItems[0].Tag;
        this.propertyGrid1.SelectedObject = ExampleCreation.CreateObject(en);
      }
    }

    private void btnSerializeBinFormat_Click(object sender, EventArgs e)
    {
      BinaryFormatter_Serialize();
    }

    private void btnDeserializeBinFormat_Click(object sender, EventArgs e)
    {
      BinaryFormatter_Deserialize();
    }

    private void btnSerializeSoap_Click(object sender, EventArgs e)
    {
      SoapFormatter_Serialize();
    }

    private void btnDeserializeSoap_Click(object sender, EventArgs e)
    {
      SoapFormatter_Deserialize();
    }

    private void btnSerializeXmlSerializer_Click(object sender, EventArgs e)
    {
      XmlSerializer_Serialize();
    }

    private void btnDeserializeXmlSerialize_Click(object sender, EventArgs e)
    {
      XmlSerializer_Deserialize();
    }

    private void btnDeserialize_Click(object sender, EventArgs e)
    {
      DeepXmlSerializer_Deserialize();
    }

    private void btnSerialize_Click(object sender, EventArgs e)
    {
      DeepXmlSerializer_Serialize();
    }


    #endregion Events
  }
}