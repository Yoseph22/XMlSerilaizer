namespace XmlSerializerDemo
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
      this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.btnClearGrid = new System.Windows.Forms.Button();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.propertyGrid2 = new System.Windows.Forms.PropertyGrid();
      this.btnDeserialize = new System.Windows.Forms.Button();
      this.btnSerialize = new System.Windows.Forms.Button();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.btnDeserializeXmlSerialize = new System.Windows.Forms.Button();
      this.btnSerializeXmlSerializer = new System.Windows.Forms.Button();
      this.tabPage3 = new System.Windows.Forms.TabPage();
      this.btnDeserializeBinFormat = new System.Windows.Forms.Button();
      this.btnSerializeBinFormat = new System.Windows.Forms.Button();
      this.tabPage4 = new System.Windows.Forms.TabPage();
      this.btnDeserializeSoap = new System.Windows.Forms.Button();
      this.btnSerializeSoap = new System.Windows.Forms.Button();
      this.imageList1 = new System.Windows.Forms.ImageList(this.components);
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.listView1 = new System.Windows.Forms.ListView();
      this.checkBoxIgnoreAttribute = new System.Windows.Forms.CheckBox();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.tabPage3.SuspendLayout();
      this.tabPage4.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // propertyGrid1
      // 
      this.propertyGrid1.Location = new System.Drawing.Point(389, 10);
      this.propertyGrid1.Name = "propertyGrid1";
      this.propertyGrid1.Size = new System.Drawing.Size(314, 431);
      this.propertyGrid1.TabIndex = 0;
      // 
      // saveFileDialog1
      // 
      this.saveFileDialog1.InitialDirectory = ".";
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      this.openFileDialog1.InitialDirectory = ".";
      // 
      // btnClearGrid
      // 
      this.btnClearGrid.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btnClearGrid.Location = new System.Drawing.Point(658, 10);
      this.btnClearGrid.Name = "btnClearGrid";
      this.btnClearGrid.Size = new System.Drawing.Size(45, 23);
      this.btnClearGrid.TabIndex = 9;
      this.btnClearGrid.Text = "Clear";
      this.btnClearGrid.UseVisualStyleBackColor = true;
      this.btnClearGrid.Click += new System.EventHandler(this.btnClearGrid_Click);
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Controls.Add(this.tabPage3);
      this.tabControl1.Controls.Add(this.tabPage4);
      this.tabControl1.Location = new System.Drawing.Point(0, 213);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(383, 228);
      this.tabControl1.TabIndex = 13;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.checkBoxIgnoreAttribute);
      this.tabPage1.Controls.Add(this.propertyGrid2);
      this.tabPage1.Controls.Add(this.btnDeserialize);
      this.tabPage1.Controls.Add(this.btnSerialize);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(375, 202);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Deep XmlSerializer";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // propertyGrid2
      // 
      this.propertyGrid2.Location = new System.Drawing.Point(114, 6);
      this.propertyGrid2.Name = "propertyGrid2";
      this.propertyGrid2.Size = new System.Drawing.Size(255, 190);
      this.propertyGrid2.TabIndex = 9;
      this.propertyGrid2.ToolbarVisible = false;
      // 
      // btnDeserialize
      // 
      this.btnDeserialize.Location = new System.Drawing.Point(8, 36);
      this.btnDeserialize.Name = "btnDeserialize";
      this.btnDeserialize.Size = new System.Drawing.Size(100, 24);
      this.btnDeserialize.TabIndex = 8;
      this.btnDeserialize.Text = "Deserialize";
      this.btnDeserialize.UseVisualStyleBackColor = true;
      this.btnDeserialize.Click += new System.EventHandler(this.btnDeserialize_Click);
      // 
      // btnSerialize
      // 
      this.btnSerialize.Location = new System.Drawing.Point(8, 6);
      this.btnSerialize.Name = "btnSerialize";
      this.btnSerialize.Size = new System.Drawing.Size(100, 24);
      this.btnSerialize.TabIndex = 7;
      this.btnSerialize.Text = "Serialize";
      this.btnSerialize.UseVisualStyleBackColor = true;
      this.btnSerialize.Click += new System.EventHandler(this.btnSerialize_Click);
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.btnDeserializeXmlSerialize);
      this.tabPage2.Controls.Add(this.btnSerializeXmlSerializer);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(375, 202);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Xml XmlSerializer";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // btnDeserializeXmlSerialize
      // 
      this.btnDeserializeXmlSerialize.Location = new System.Drawing.Point(8, 36);
      this.btnDeserializeXmlSerialize.Name = "btnDeserializeXmlSerialize";
      this.btnDeserializeXmlSerialize.Size = new System.Drawing.Size(100, 24);
      this.btnDeserializeXmlSerialize.TabIndex = 7;
      this.btnDeserializeXmlSerialize.Text = "Deserialize";
      this.btnDeserializeXmlSerialize.UseVisualStyleBackColor = true;
      this.btnDeserializeXmlSerialize.Click += new System.EventHandler(this.btnDeserializeXmlSerialize_Click);
      // 
      // btnSerializeXmlSerializer
      // 
      this.btnSerializeXmlSerializer.Location = new System.Drawing.Point(8, 6);
      this.btnSerializeXmlSerializer.Name = "btnSerializeXmlSerializer";
      this.btnSerializeXmlSerializer.Size = new System.Drawing.Size(100, 24);
      this.btnSerializeXmlSerializer.TabIndex = 6;
      this.btnSerializeXmlSerializer.Text = "Serialize";
      this.btnSerializeXmlSerializer.UseVisualStyleBackColor = true;
      this.btnSerializeXmlSerializer.Click += new System.EventHandler(this.btnSerializeXmlSerializer_Click);
      // 
      // tabPage3
      // 
      this.tabPage3.Controls.Add(this.btnDeserializeBinFormat);
      this.tabPage3.Controls.Add(this.btnSerializeBinFormat);
      this.tabPage3.Location = new System.Drawing.Point(4, 22);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Size = new System.Drawing.Size(375, 202);
      this.tabPage3.TabIndex = 2;
      this.tabPage3.Text = "BinaryFormatter";
      this.tabPage3.UseVisualStyleBackColor = true;
      // 
      // btnDeserializeBinFormat
      // 
      this.btnDeserializeBinFormat.Location = new System.Drawing.Point(8, 36);
      this.btnDeserializeBinFormat.Name = "btnDeserializeBinFormat";
      this.btnDeserializeBinFormat.Size = new System.Drawing.Size(100, 24);
      this.btnDeserializeBinFormat.TabIndex = 7;
      this.btnDeserializeBinFormat.Text = "Deserialize";
      this.btnDeserializeBinFormat.UseVisualStyleBackColor = true;
      this.btnDeserializeBinFormat.Click += new System.EventHandler(this.btnDeserializeBinFormat_Click);
      // 
      // btnSerializeBinFormat
      // 
      this.btnSerializeBinFormat.Location = new System.Drawing.Point(8, 6);
      this.btnSerializeBinFormat.Name = "btnSerializeBinFormat";
      this.btnSerializeBinFormat.Size = new System.Drawing.Size(100, 24);
      this.btnSerializeBinFormat.TabIndex = 6;
      this.btnSerializeBinFormat.Text = "Serialize";
      this.btnSerializeBinFormat.UseVisualStyleBackColor = true;
      this.btnSerializeBinFormat.Click += new System.EventHandler(this.btnSerializeBinFormat_Click);
      // 
      // tabPage4
      // 
      this.tabPage4.Controls.Add(this.btnDeserializeSoap);
      this.tabPage4.Controls.Add(this.btnSerializeSoap);
      this.tabPage4.Location = new System.Drawing.Point(4, 22);
      this.tabPage4.Name = "tabPage4";
      this.tabPage4.Size = new System.Drawing.Size(375, 202);
      this.tabPage4.TabIndex = 3;
      this.tabPage4.Text = "SoapFormatter";
      this.tabPage4.UseVisualStyleBackColor = true;
      // 
      // btnDeserializeSoap
      // 
      this.btnDeserializeSoap.Location = new System.Drawing.Point(8, 36);
      this.btnDeserializeSoap.Name = "btnDeserializeSoap";
      this.btnDeserializeSoap.Size = new System.Drawing.Size(100, 24);
      this.btnDeserializeSoap.TabIndex = 9;
      this.btnDeserializeSoap.Text = "Deserialize";
      this.btnDeserializeSoap.UseVisualStyleBackColor = true;
      this.btnDeserializeSoap.Click += new System.EventHandler(this.btnDeserializeSoap_Click);
      // 
      // btnSerializeSoap
      // 
      this.btnSerializeSoap.Location = new System.Drawing.Point(8, 6);
      this.btnSerializeSoap.Name = "btnSerializeSoap";
      this.btnSerializeSoap.Size = new System.Drawing.Size(100, 24);
      this.btnSerializeSoap.TabIndex = 8;
      this.btnSerializeSoap.Text = "Serialize";
      this.btnSerializeSoap.UseVisualStyleBackColor = true;
      this.btnSerializeSoap.Click += new System.EventHandler(this.btnSerializeSoap_Click);
      // 
      // imageList1
      // 
      this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
      this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
      this.imageList1.Images.SetKeyName(0, "bullet_black.png");
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.listView1);
      this.groupBox1.Location = new System.Drawing.Point(0, 10);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(383, 197);
      this.groupBox1.TabIndex = 15;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Object to-be serialized (Double Click!)";
      // 
      // listView1
      // 
      this.listView1.FullRowSelect = true;
      this.listView1.HideSelection = false;
      this.listView1.Location = new System.Drawing.Point(4, 19);
      this.listView1.MultiSelect = false;
      this.listView1.Name = "listView1";
      this.listView1.Size = new System.Drawing.Size(373, 172);
      this.listView1.SmallImageList = this.imageList1;
      this.listView1.TabIndex = 15;
      this.listView1.UseCompatibleStateImageBehavior = false;
      this.listView1.View = System.Windows.Forms.View.List;
      this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
      // 
      // checkBoxIgnoreAttribute
      // 
      this.checkBoxIgnoreAttribute.Location = new System.Drawing.Point(12, 77);
      this.checkBoxIgnoreAttribute.Name = "checkBoxIgnoreAttribute";
      this.checkBoxIgnoreAttribute.Size = new System.Drawing.Size(95, 39);
      this.checkBoxIgnoreAttribute.TabIndex = 10;
      this.checkBoxIgnoreAttribute.Text = "Set Ignore Attribute";
      this.checkBoxIgnoreAttribute.UseVisualStyleBackColor = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(705, 443);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.btnClearGrid);
      this.Controls.Add(this.propertyGrid1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      this.tabPage3.ResumeLayout(false);
      this.tabPage4.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PropertyGrid propertyGrid1;
    private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.Button btnClearGrid;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.PropertyGrid propertyGrid2;
    private System.Windows.Forms.Button btnDeserialize;
    private System.Windows.Forms.Button btnSerialize;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.Button btnDeserializeXmlSerialize;
    private System.Windows.Forms.Button btnSerializeXmlSerializer;
    private System.Windows.Forms.TabPage tabPage3;
    private System.Windows.Forms.Button btnDeserializeBinFormat;
    private System.Windows.Forms.Button btnSerializeBinFormat;
    private System.Windows.Forms.ImageList imageList1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.ListView listView1;
    private System.Windows.Forms.TabPage tabPage4;
    private System.Windows.Forms.Button btnDeserializeSoap;
    private System.Windows.Forms.Button btnSerializeSoap;
    private System.Windows.Forms.CheckBox checkBoxIgnoreAttribute;
  }
}

