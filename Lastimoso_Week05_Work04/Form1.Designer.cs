namespace Lastimoso_Week05_Work04
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
            this.lblBarcode = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescrip = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAbroad = new System.Windows.Forms.RadioButton();
            this.lblLocal = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblActive = new System.Windows.Forms.CheckBox();
            this.lblCost = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.lblCancel = new System.Windows.Forms.Button();
            this.lblClear = new System.Windows.Forms.Button();
            this.lblSave = new System.Windows.Forms.Button();
            this.lblCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Location = new System.Drawing.Point(13, 13);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(59, 16);
            this.lblBarcode.TabIndex = 0;
            this.lblBarcode.Text = "Barcode";
            // 
            // lblCode
            // 
            this.lblCode.Location = new System.Drawing.Point(169, 13);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(331, 22);
            this.lblCode.TabIndex = 1;
            this.lblCode.TextChanged += new System.EventHandler(this.lblCode_TextChanged);
            // 
            // lblProductName
            // 
            this.lblProductName.Location = new System.Drawing.Point(169, 52);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(331, 22);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.TextChanged += new System.EventHandler(this.lblProductName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 52);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // lblDescrip
            // 
            this.lblDescrip.AutoSize = true;
            this.lblDescrip.Location = new System.Drawing.Point(13, 79);
            this.lblDescrip.Name = "lblDescrip";
            this.lblDescrip.Size = new System.Drawing.Size(75, 16);
            this.lblDescrip.TabIndex = 4;
            this.lblDescrip.Text = "Description";
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(169, 80);
            this.lblDescription.Multiline = true;
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(331, 121);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.TextChanged += new System.EventHandler(this.lblDescription_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Origin";
            // 
            // lblAbroad
            // 
            this.lblAbroad.AutoSize = true;
            this.lblAbroad.Location = new System.Drawing.Point(199, 37);
            this.lblAbroad.Name = "lblAbroad";
            this.lblAbroad.Size = new System.Drawing.Size(73, 20);
            this.lblAbroad.TabIndex = 9;
            this.lblAbroad.TabStop = true;
            this.lblAbroad.Text = "Abroad";
            this.lblAbroad.UseVisualStyleBackColor = true;
            this.lblAbroad.CheckedChanged += new System.EventHandler(this.lblAbroad_CheckedChanged);
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Location = new System.Drawing.Point(17, 37);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(61, 20);
            this.lblLocal.TabIndex = 10;
            this.lblLocal.TabStop = true;
            this.lblLocal.Text = "Local";
            this.lblLocal.UseVisualStyleBackColor = true;
            this.lblLocal.CheckedChanged += new System.EventHandler(this.lblLocal_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblLocal);
            this.groupBox1.Controls.Add(this.lblAbroad);
            this.groupBox1.Location = new System.Drawing.Point(169, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 81);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manufacture";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Status";
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Location = new System.Drawing.Point(169, 342);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(66, 20);
            this.lblActive.TabIndex = 13;
            this.lblActive.Text = "Active";
            this.lblActive.UseVisualStyleBackColor = true;
            this.lblActive.CheckedChanged += new System.EventHandler(this.lblActive_CheckedChanged);
            // 
            // lblCost
            // 
            this.lblCost.Location = new System.Drawing.Point(12, 407);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(157, 22);
            this.lblCost.TabIndex = 14;
            this.lblCost.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(186, 407);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(157, 22);
            this.textBox6.TabIndex = 15;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(391, 407);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(109, 22);
            this.textBox7.TabIndex = 16;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // lblCancel
            // 
            this.lblCancel.Location = new System.Drawing.Point(16, 462);
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.Size = new System.Drawing.Size(153, 33);
            this.lblCancel.TabIndex = 17;
            this.lblCancel.Text = "Cancel";
            this.lblCancel.UseVisualStyleBackColor = true;
            this.lblCancel.Click += new System.EventHandler(this.lblCancel_Click);
            // 
            // lblClear
            // 
            this.lblClear.Location = new System.Drawing.Point(186, 462);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(153, 33);
            this.lblClear.TabIndex = 18;
            this.lblClear.Text = "Clear";
            this.lblClear.UseVisualStyleBackColor = true;
            this.lblClear.Click += new System.EventHandler(this.lblClear_Click);
            // 
            // lblSave
            // 
            this.lblSave.Location = new System.Drawing.Point(391, 462);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(109, 33);
            this.lblSave.TabIndex = 19;
            this.lblSave.Text = "Save";
            this.lblSave.UseVisualStyleBackColor = true;
            this.lblSave.Click += new System.EventHandler(this.lblSave_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.FormattingEnabled = true;
            this.lblCategory.Location = new System.Drawing.Point(169, 207);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(331, 24);
            this.lblCategory.TabIndex = 20;
            this.lblCategory.SelectedIndexChanged += new System.EventHandler(this.lblCategory_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(388, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Markup(%)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label7.Location = new System.Drawing.Point(166, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Barcode is available";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 519);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblSave);
            this.Controls.Add(this.lblClear);
            this.Controls.Add(this.lblCancel);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblActive);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblDescrip);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblBarcode);
            this.Name = "Form1";
            this.Text = "Product Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.TextBox lblCode;
        private System.Windows.Forms.TextBox lblProductName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescrip;
        private System.Windows.Forms.TextBox lblDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton lblAbroad;
        private System.Windows.Forms.RadioButton lblLocal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox lblActive;
        private System.Windows.Forms.TextBox lblCost;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button lblCancel;
        private System.Windows.Forms.Button lblClear;
        private System.Windows.Forms.Button lblSave;
        private System.Windows.Forms.ComboBox lblCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

