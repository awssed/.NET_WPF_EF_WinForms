using System;

namespace Lab2_WinFromsControlElements_
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBarSeats = new System.Windows.Forms.TrackBar();
            this.numericSeats = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericYear = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numericWeight = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.labelModel = new System.Windows.Forms.Label();
            this.labelCrew = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelSeats = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.buttonExport = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ImportList = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolExport = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolInput = new System.Windows.Forms.ToolStripButton();
            this.toolSearch = new System.Windows.Forms.ToolStripButton();
            this.toolAbout = new System.Windows.Forms.ToolStripButton();
            this.buttonHideTool = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.TechServ = new System.Windows.Forms.MonthCalendar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.toolStripStatusLabelTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYear)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericWeight)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Flight";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(24, 49);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(117, 20);
            this.textBoxId.TabIndex = 1;
            this.textBoxId.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxId_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Model";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Boeing",
            "Airbus",
            "Embraer",
            "CRJ"});
            this.comboBox1.Location = new System.Drawing.Point(25, 93);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(117, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            this.comboBox1.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox1_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(21, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number of seats";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // trackBarSeats
            // 
            this.trackBarSeats.Location = new System.Drawing.Point(25, 138);
            this.trackBarSeats.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarSeats.Maximum = 300;
            this.trackBarSeats.Name = "trackBarSeats";
            this.trackBarSeats.Size = new System.Drawing.Size(100, 45);
            this.trackBarSeats.TabIndex = 5;
            this.trackBarSeats.ValueChanged += new System.EventHandler(this.trackBarSeats_ValueChanged);
            // 
            // numericSeats
            // 
            this.numericSeats.Location = new System.Drawing.Point(129, 138);
            this.numericSeats.Margin = new System.Windows.Forms.Padding(2);
            this.numericSeats.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericSeats.Name = "numericSeats";
            this.numericSeats.Size = new System.Drawing.Size(46, 20);
            this.numericSeats.TabIndex = 6;
            this.numericSeats.ValueChanged += new System.EventHandler(this.numericSeats_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(20, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Year of reales";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // numericYear
            // 
            this.numericYear.Location = new System.Drawing.Point(28, 190);
            this.numericYear.Margin = new System.Windows.Forms.Padding(2);
            this.numericYear.Maximum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.numericYear.Minimum = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            this.numericYear.Name = "numericYear";
            this.numericYear.Size = new System.Drawing.Size(112, 20);
            this.numericYear.TabIndex = 8;
            this.numericYear.Value = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            this.numericYear.ValueChanged += new System.EventHandler(this.numericYear_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(24, 224);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(124, 85);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(2, 61);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(75, 24);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Military";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(2, 40);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(77, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Frieght";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(2, 21);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(75, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Civilian";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(28, 315);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "Crew";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(25, 349);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tech Service";
            // 
            // numericWeight
            // 
            this.numericWeight.Location = new System.Drawing.Point(32, 570);
            this.numericWeight.Margin = new System.Windows.Forms.Padding(2);
            this.numericWeight.Name = "numericWeight";
            this.numericWeight.Size = new System.Drawing.Size(112, 20);
            this.numericWeight.TabIndex = 16;
            this.numericWeight.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(28, 547);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Weight";
            // 
            // buttonAccept
            // 
            this.buttonAccept.Enabled = false;
            this.buttonAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAccept.Location = new System.Drawing.Point(32, 603);
            this.buttonAccept.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(66, 31);
            this.buttonAccept.TabIndex = 17;
            this.buttonAccept.Text = "Accept";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelModel.ForeColor = System.Drawing.Color.Red;
            this.labelModel.Location = new System.Drawing.Point(146, 86);
            this.labelModel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(18, 26);
            this.labelModel.TabIndex = 18;
            this.labelModel.Text = "!";
            this.labelModel.Click += new System.EventHandler(this.label7_Click);
            // 
            // labelCrew
            // 
            this.labelCrew.AutoSize = true;
            this.labelCrew.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCrew.ForeColor = System.Drawing.Color.Red;
            this.labelCrew.Location = new System.Drawing.Point(88, 317);
            this.labelCrew.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCrew.Name = "labelCrew";
            this.labelCrew.Size = new System.Drawing.Size(18, 26);
            this.labelCrew.TabIndex = 19;
            this.labelCrew.Text = "!";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.ForeColor = System.Drawing.Color.Red;
            this.labelDate.Location = new System.Drawing.Point(191, 377);
            this.labelDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(18, 26);
            this.labelDate.TabIndex = 20;
            this.labelDate.Text = "!";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWeight.ForeColor = System.Drawing.Color.Red;
            this.labelWeight.Location = new System.Drawing.Point(158, 562);
            this.labelWeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(18, 26);
            this.labelWeight.TabIndex = 21;
            this.labelWeight.Text = "!";
            // 
            // labelSeats
            // 
            this.labelSeats.AutoSize = true;
            this.labelSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSeats.ForeColor = System.Drawing.Color.Red;
            this.labelSeats.Location = new System.Drawing.Point(191, 129);
            this.labelSeats.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSeats.Name = "labelSeats";
            this.labelSeats.Size = new System.Drawing.Size(18, 26);
            this.labelSeats.TabIndex = 22;
            this.labelSeats.Text = "!";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelYear.ForeColor = System.Drawing.Color.Red;
            this.labelYear.Location = new System.Drawing.Point(156, 181);
            this.labelYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(18, 26);
            this.labelYear.TabIndex = 23;
            this.labelYear.Text = "!";
            // 
            // buttonExport
            // 
            this.buttonExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExport.Location = new System.Drawing.Point(251, 38);
            this.buttonExport.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(67, 29);
            this.buttonExport.TabIndex = 24;
            this.buttonExport.Text = "Export JSON";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(322, 38);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 29);
            this.button3.TabIndex = 25;
            this.button3.Text = "Import JSON";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // ImportList
            // 
            this.ImportList.AllowDrop = true;
            this.ImportList.Location = new System.Drawing.Point(251, 73);
            this.ImportList.Margin = new System.Windows.Forms.Padding(2);
            this.ImportList.Multiline = true;
            this.ImportList.Name = "ImportList";
            this.ImportList.ReadOnly = true;
            this.ImportList.Size = new System.Drawing.Size(196, 562);
            this.ImportList.TabIndex = 26;
            this.ImportList.DragDrop += new System.Windows.Forms.DragEventHandler(this.ImportList_DragDrop);
            this.ImportList.DragEnter += new System.Windows.Forms.DragEventHandler(this.ImportList_DragEnter);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(382, 38);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 29);
            this.button2.TabIndex = 27;
            this.button2.Text = "Вперёд";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolExport,
            this.toolStripButton2,
            this.toolInput,
            this.toolSearch,
            this.toolAbout});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(488, 25);
            this.toolStrip1.TabIndex = 29;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolExport
            // 
            this.toolExport.Image = ((System.Drawing.Image)(resources.GetObject("toolExport.Image")));
            this.toolExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolExport.Name = "toolExport";
            this.toolExport.Size = new System.Drawing.Size(61, 22);
            this.toolExport.Text = "Export";
            this.toolExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Import";
            // 
            // toolInput
            // 
            this.toolInput.Image = ((System.Drawing.Image)(resources.GetObject("toolInput.Image")));
            this.toolInput.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolInput.Name = "toolInput";
            this.toolInput.Size = new System.Drawing.Size(63, 22);
            this.toolInput.Text = "Import";
            this.toolInput.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // toolSearch
            // 
            this.toolSearch.Image = ((System.Drawing.Image)(resources.GetObject("toolSearch.Image")));
            this.toolSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSearch.Name = "toolSearch";
            this.toolSearch.Size = new System.Drawing.Size(62, 22);
            this.toolSearch.Text = "Search";
            this.toolSearch.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // toolAbout
            // 
            this.toolAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolAbout.Image = ((System.Drawing.Image)(resources.GetObject("toolAbout.Image")));
            this.toolAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAbout.Name = "toolAbout";
            this.toolAbout.Size = new System.Drawing.Size(104, 22);
            this.toolAbout.Text = "About programm";
            this.toolAbout.Click += new System.EventHandler(this.toolAbout_Click);
            // 
            // buttonHideTool
            // 
            this.buttonHideTool.BackgroundImage = global::Lab2_WinFromsControlElements_.Properties.Resources.images;
            this.buttonHideTool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonHideTool.Location = new System.Drawing.Point(450, 1);
            this.buttonHideTool.Name = "buttonHideTool";
            this.buttonHideTool.Size = new System.Drawing.Size(26, 24);
            this.buttonHideTool.TabIndex = 30;
            this.buttonHideTool.UseVisualStyleBackColor = true;
            this.buttonHideTool.Click += new System.EventHandler(this.buttonHIdeTool_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.BackgroundImage = global::Lab2_WinFromsControlElements_.Properties.Resources._81996;
            this.buttonSort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSort.Location = new System.Drawing.Point(214, 73);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(32, 31);
            this.buttonSort.TabIndex = 28;
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(282, 641);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 13);
            this.labelStatus.TabIndex = 31;
            // 
            // TechServ
            // 
            this.TechServ.Location = new System.Drawing.Point(28, 377);
            this.TechServ.Margin = new System.Windows.Forms.Padding(7);
            this.TechServ.MaxDate = new System.DateTime(2024, 2, 26, 18, 32, 39, 960);
            this.TechServ.Name = "TechServ";
            this.TechServ.TabIndex = 12;
            this.TechServ.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.TechServ_DateChanged);
            this.TechServ.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.TechServ_DateSelected);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 640);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(488, 22);
            this.statusStrip1.TabIndex = 32;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.Location = new System.Drawing.Point(181, 38);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(65, 29);
            this.buttonClear.TabIndex = 33;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // toolStripStatusLabelTime
            // 
            this.toolStripStatusLabelTime.Name = "toolStripStatusLabelTime";
            this.toolStripStatusLabelTime.Size = new System.Drawing.Size(0, 17);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::Lab2_WinFromsControlElements_.Properties.Resources._81996;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(214, 111);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 31);
            this.button4.TabIndex = 34;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 662);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonHideTool);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ImportList);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelSeats);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelCrew);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.numericWeight);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TechServ);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numericYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericSeats);
            this.Controls.Add(this.trackBarSeats);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "          ";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYear)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericWeight)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBarSeats;
        private System.Windows.Forms.NumericUpDown numericSeats;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericYear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericWeight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelCrew;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelSeats;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox ImportList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolExport;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolInput;
        private System.Windows.Forms.ToolStripButton toolSearch;
        private System.Windows.Forms.Button buttonHideTool;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ToolStripButton toolAbout;
        private System.Windows.Forms.MonthCalendar TechServ;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button4;
    }
}

