namespace Lab2_WinFromsControlElements_
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numeriсAge = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericExp = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxPos = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelCrew = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numeriсAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericExp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "FIO";
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(18, 41);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(248, 22);
            this.textBoxFIO.TabIndex = 1;
            this.textBoxFIO.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxFIO_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Age";
            // 
            // numeriсAge
            // 
            this.numeriсAge.Location = new System.Drawing.Point(18, 95);
            this.numeriсAge.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numeriсAge.Name = "numeriсAge";
            this.numeriсAge.Size = new System.Drawing.Size(248, 22);
            this.numeriсAge.TabIndex = 3;
            this.numeriсAge.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Experience";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // numericExp
            // 
            this.numericExp.Location = new System.Drawing.Point(18, 157);
            this.numericExp.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericExp.Name = "numericExp";
            this.numericExp.Size = new System.Drawing.Size(248, 22);
            this.numericExp.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Position";
            // 
            // comboBoxPos
            // 
            this.comboBoxPos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxPos.FormattingEnabled = true;
            this.comboBoxPos.Items.AddRange(new object[] {
            "Pilot",
            "Stewardess"});
            this.comboBoxPos.Location = new System.Drawing.Point(18, 222);
            this.comboBoxPos.Name = "comboBoxPos";
            this.comboBoxPos.Size = new System.Drawing.Size(219, 28);
            this.comboBoxPos.TabIndex = 7;
            this.comboBoxPos.SelectedIndexChanged += new System.EventHandler(this.comboBoxPos_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Accept";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelCrew
            // 
            this.labelCrew.AutoSize = true;
            this.labelCrew.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCrew.ForeColor = System.Drawing.Color.Red;
            this.labelCrew.Location = new System.Drawing.Point(244, 222);
            this.labelCrew.Name = "labelCrew";
            this.labelCrew.Size = new System.Drawing.Size(22, 32);
            this.labelCrew.TabIndex = 9;
            this.labelCrew.Text = "!";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 314);
            this.Controls.Add(this.labelCrew);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxPos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericExp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numeriсAge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Crew";
            ((System.ComponentModel.ISupportInitialize)(this.numeriсAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericExp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numeriсAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericExp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxPos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelCrew;
    }
}