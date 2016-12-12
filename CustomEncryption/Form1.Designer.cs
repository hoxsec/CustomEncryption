namespace CustomEncryption
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxText = new System.Windows.Forms.CheckBox();
            this.checkBoxDecryption = new System.Windows.Forms.CheckBox();
            this.checkBoxEncryption = new System.Windows.Forms.CheckBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtSave = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.currentStageLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.labelTextKey = new System.Windows.Forms.Label();
            this.btnText = new System.Windows.Forms.Button();
            this.txtTextKey = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.labelPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxText);
            this.groupBox1.Controls.Add(this.checkBoxDecryption);
            this.groupBox1.Controls.Add(this.checkBoxEncryption);
            this.groupBox1.Location = new System.Drawing.Point(3, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // checkBoxText
            // 
            this.checkBoxText.AutoSize = true;
            this.checkBoxText.Location = new System.Drawing.Point(517, 19);
            this.checkBoxText.Name = "checkBoxText";
            this.checkBoxText.Size = new System.Drawing.Size(47, 17);
            this.checkBoxText.TabIndex = 2;
            this.checkBoxText.Text = "Text";
            this.checkBoxText.UseVisualStyleBackColor = true;
            this.checkBoxText.CheckedChanged += new System.EventHandler(this.checkBoxText_CheckedChanged);
            // 
            // checkBoxDecryption
            // 
            this.checkBoxDecryption.AutoSize = true;
            this.checkBoxDecryption.Location = new System.Drawing.Point(259, 19);
            this.checkBoxDecryption.Name = "checkBoxDecryption";
            this.checkBoxDecryption.Size = new System.Drawing.Size(77, 17);
            this.checkBoxDecryption.TabIndex = 1;
            this.checkBoxDecryption.Text = "Decryption";
            this.checkBoxDecryption.UseVisualStyleBackColor = true;
            this.checkBoxDecryption.CheckedChanged += new System.EventHandler(this.checkBoxDecryption_CheckedChanged);
            // 
            // checkBoxEncryption
            // 
            this.checkBoxEncryption.AutoSize = true;
            this.checkBoxEncryption.Location = new System.Drawing.Point(11, 19);
            this.checkBoxEncryption.Name = "checkBoxEncryption";
            this.checkBoxEncryption.Size = new System.Drawing.Size(76, 17);
            this.checkBoxEncryption.TabIndex = 0;
            this.checkBoxEncryption.Text = "Encryption";
            this.checkBoxEncryption.UseVisualStyleBackColor = true;
            this.checkBoxEncryption.CheckedChanged += new System.EventHandler(this.checkBoxEncryption_CheckedChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(112, 71);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(227, 20);
            this.txtSearch.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Key :";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(406, 71);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(176, 20);
            this.txtKey.TabIndex = 5;
            // 
            // txtSave
            // 
            this.txtSave.Location = new System.Drawing.Point(112, 114);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(227, 20);
            this.txtSave.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(406, 112);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Encryption";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.currentStageLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 471);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(598, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(164, 17);
            this.toolStripStatusLabel1.Text = "Copyright 2016 UmitCanbolat";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(82, 17);
            this.toolStripStatusLabel2.Text = "Current State :";
            // 
            // currentStageLabel
            // 
            this.currentStageLabel.Name = "currentStageLabel";
            this.currentStageLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 69);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(269, 329);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(313, 69);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(269, 329);
            this.richTextBox2.TabIndex = 10;
            this.richTextBox2.Text = "";
            // 
            // labelTextKey
            // 
            this.labelTextKey.AutoSize = true;
            this.labelTextKey.Location = new System.Drawing.Point(437, 427);
            this.labelTextKey.Name = "labelTextKey";
            this.labelTextKey.Size = new System.Drawing.Size(31, 13);
            this.labelTextKey.TabIndex = 11;
            this.labelTextKey.Text = "Key :";
            // 
            // btnText
            // 
            this.btnText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnText.Location = new System.Drawing.Point(14, 422);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(88, 23);
            this.btnText.TabIndex = 12;
            this.btnText.Text = "Choose Options";
            this.btnText.UseVisualStyleBackColor = true;
            this.btnText.Click += new System.EventHandler(this.btnText_Click);
            // 
            // txtTextKey
            // 
            this.txtTextKey.Location = new System.Drawing.Point(474, 424);
            this.txtTextKey.Name = "txtTextKey";
            this.txtTextKey.Size = new System.Drawing.Size(112, 20);
            this.txtTextKey.TabIndex = 13;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(254, 427);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(59, 13);
            this.labelPassword.TabIndex = 14;
            this.labelPassword.Text = "Password :";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(319, 424);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(112, 20);
            this.txtPassword.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Image = global::CustomEncryption.Properties.Resources.save_file;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(12, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Save in";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::CustomEncryption.Properties.Resources.Search;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(598, 493);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.txtTextKey);
            this.Controls.Add(this.btnText);
            this.Controls.Add(this.labelTextKey);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtSave);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(614, 532);
            this.MinimumSize = new System.Drawing.Size(614, 532);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C# Encryption";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxText;
        private System.Windows.Forms.CheckBox checkBoxDecryption;
        private System.Windows.Forms.CheckBox checkBoxEncryption;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtSave;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel currentStageLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label labelTextKey;
        private System.Windows.Forms.Button btnText;
        private System.Windows.Forms.TextBox txtTextKey;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox txtPassword;
    }
}

