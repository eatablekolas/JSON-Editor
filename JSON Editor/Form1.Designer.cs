namespace JSON_Editor
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.loadedFileLabel = new System.Windows.Forms.Label();
            this.openButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addAttributeButton = new System.Windows.Forms.Button();
            this.addSubcategoryButton = new System.Windows.Forms.Button();
            this.addCategoryButton = new System.Windows.Forms.Button();
            this.editWindow = new System.Windows.Forms.GroupBox();
            this.attributeWindow = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.numberBox = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.boolBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.stringBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolPanel = new System.Windows.Forms.Panel();
            this.sortButton = new System.Windows.Forms.Button();
            this.submitAttributeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.editWindow.SuspendLayout();
            this.attributeWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBox)).BeginInit();
            this.toolPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wczytany plik:";
            // 
            // createButton
            // 
            this.createButton.AutoSize = true;
            this.createButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.createButton.Location = new System.Drawing.Point(11, 11);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(137, 23);
            this.createButton.TabIndex = 0;
            this.createButton.Text = "Utwórz nowy plik JSON...";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.loadedFileLabel);
            this.splitContainer1.Panel1.Controls.Add(this.openButton);
            this.splitContainer1.Panel1.Controls.Add(this.createButton);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(513, 483);
            this.splitContainer1.SplitterDistance = 169;
            this.splitContainer1.TabIndex = 2;
            // 
            // loadedFileLabel
            // 
            this.loadedFileLabel.AutoEllipsis = true;
            this.loadedFileLabel.Location = new System.Drawing.Point(11, 106);
            this.loadedFileLabel.Name = "loadedFileLabel";
            this.loadedFileLabel.Size = new System.Drawing.Size(137, 371);
            this.loadedFileLabel.TabIndex = 3;
            // 
            // openButton
            // 
            this.openButton.AutoSize = true;
            this.openButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.openButton.Location = new System.Drawing.Point(11, 41);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(78, 23);
            this.openButton.TabIndex = 2;
            this.openButton.Text = "Otwórz plik...";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(167, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(338, 481);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer2);
            this.tabPage1.Controls.Add(this.treeView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(330, 455);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kategorie";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(3, 273);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.editWindow);
            this.splitContainer2.Size = new System.Drawing.Size(324, 179);
            this.splitContainer2.SplitterDistance = 140;
            this.splitContainer2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sortButton);
            this.groupBox1.Controls.Add(this.toolPanel);
            this.groupBox1.Controls.Add(this.addCategoryButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 179);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Narzędzia";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(2, 61);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(127, 34);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Usuń zaznaczony element";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addAttributeButton
            // 
            this.addAttributeButton.Location = new System.Drawing.Point(3, 32);
            this.addAttributeButton.Name = "addAttributeButton";
            this.addAttributeButton.Size = new System.Drawing.Size(127, 23);
            this.addAttributeButton.TabIndex = 2;
            this.addAttributeButton.Text = "Dodaj właściwość";
            this.addAttributeButton.UseVisualStyleBackColor = true;
            this.addAttributeButton.Click += new System.EventHandler(this.addAttributeButton_Click);
            // 
            // addSubcategoryButton
            // 
            this.addSubcategoryButton.Location = new System.Drawing.Point(3, 3);
            this.addSubcategoryButton.Name = "addSubcategoryButton";
            this.addSubcategoryButton.Size = new System.Drawing.Size(127, 23);
            this.addSubcategoryButton.TabIndex = 1;
            this.addSubcategoryButton.Text = "Dodaj podkategorię";
            this.addSubcategoryButton.UseVisualStyleBackColor = true;
            this.addSubcategoryButton.Click += new System.EventHandler(this.addSubcategoryButton_Click);
            // 
            // addCategoryButton
            // 
            this.addCategoryButton.Location = new System.Drawing.Point(7, 20);
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Size = new System.Drawing.Size(127, 23);
            this.addCategoryButton.TabIndex = 0;
            this.addCategoryButton.Text = "Dodaj kategorię";
            this.addCategoryButton.UseVisualStyleBackColor = true;
            this.addCategoryButton.Click += new System.EventHandler(this.addCategoryButton_Click);
            // 
            // editWindow
            // 
            this.editWindow.Controls.Add(this.attributeWindow);
            this.editWindow.Controls.Add(this.nameBox);
            this.editWindow.Controls.Add(this.label2);
            this.editWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editWindow.Enabled = false;
            this.editWindow.Location = new System.Drawing.Point(0, 0);
            this.editWindow.Name = "editWindow";
            this.editWindow.Size = new System.Drawing.Size(180, 179);
            this.editWindow.TabIndex = 0;
            this.editWindow.TabStop = false;
            this.editWindow.Text = "Edytuj";
            // 
            // attributeWindow
            // 
            this.attributeWindow.Controls.Add(this.submitAttributeButton);
            this.attributeWindow.Controls.Add(this.label3);
            this.attributeWindow.Controls.Add(this.numberBox);
            this.attributeWindow.Controls.Add(this.comboBox1);
            this.attributeWindow.Controls.Add(this.boolBox);
            this.attributeWindow.Controls.Add(this.label4);
            this.attributeWindow.Controls.Add(this.stringBox);
            this.attributeWindow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.attributeWindow.Enabled = false;
            this.attributeWindow.Location = new System.Drawing.Point(3, 48);
            this.attributeWindow.Name = "attributeWindow";
            this.attributeWindow.Size = new System.Drawing.Size(174, 128);
            this.attributeWindow.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rodzaj właściwości:";
            // 
            // numberBox
            // 
            this.numberBox.Location = new System.Drawing.Point(60, 55);
            this.numberBox.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numberBox.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            -2147483648});
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(111, 20);
            this.numberBox.TabIndex = 8;
            this.numberBox.ThousandsSeparator = true;
            this.numberBox.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "boolean (tak/nie)",
            "integer (liczba całkowita)",
            "float (liczba wymierna)",
            "string (tekst)"});
            this.comboBox1.Location = new System.Drawing.Point(7, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // boolBox
            // 
            this.boolBox.AutoSize = true;
            this.boolBox.Location = new System.Drawing.Point(60, 58);
            this.boolBox.Name = "boolBox";
            this.boolBox.Size = new System.Drawing.Size(15, 14);
            this.boolBox.TabIndex = 7;
            this.boolBox.UseVisualStyleBackColor = true;
            this.boolBox.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Wartość:";
            // 
            // stringBox
            // 
            this.stringBox.Location = new System.Drawing.Point(60, 55);
            this.stringBox.Name = "stringBox";
            this.stringBox.Size = new System.Drawing.Size(111, 20);
            this.stringBox.TabIndex = 6;
            this.stringBox.Visible = false;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(56, 22);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(118, 20);
            this.nameBox.TabIndex = 1;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nazwa:";
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(324, 270);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDown);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-category-48.png");
            this.imageList1.Images.SetKeyName(1, "icons8-wrench-48.png");
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(330, 455);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Przedmioty";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // toolPanel
            // 
            this.toolPanel.Controls.Add(this.addSubcategoryButton);
            this.toolPanel.Controls.Add(this.deleteButton);
            this.toolPanel.Controls.Add(this.addAttributeButton);
            this.toolPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolPanel.Enabled = false;
            this.toolPanel.Location = new System.Drawing.Point(3, 76);
            this.toolPanel.Name = "toolPanel";
            this.toolPanel.Size = new System.Drawing.Size(134, 100);
            this.toolPanel.TabIndex = 4;
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(7, 48);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(127, 22);
            this.sortButton.TabIndex = 4;
            this.sortButton.Text = "Sortuj";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // submitAttributeButton
            // 
            this.submitAttributeButton.Location = new System.Drawing.Point(60, 78);
            this.submitAttributeButton.Name = "submitAttributeButton";
            this.submitAttributeButton.Size = new System.Drawing.Size(111, 23);
            this.submitAttributeButton.TabIndex = 5;
            this.submitAttributeButton.Text = "Ustaw";
            this.submitAttributeButton.UseVisualStyleBackColor = true;
            this.submitAttributeButton.Click += new System.EventHandler(this.submitAttributeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 483);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Edytor przedmiotów";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.editWindow.ResumeLayout(false);
            this.editWindow.PerformLayout();
            this.attributeWindow.ResumeLayout(false);
            this.attributeWindow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBox)).EndInit();
            this.toolPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Label loadedFileLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addAttributeButton;
        private System.Windows.Forms.Button addSubcategoryButton;
        private System.Windows.Forms.Button addCategoryButton;
        private System.Windows.Forms.GroupBox editWindow;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stringBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox boolBox;
        private System.Windows.Forms.NumericUpDown numberBox;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel attributeWindow;
        private System.Windows.Forms.Panel toolPanel;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Button submitAttributeButton;
    }
}

