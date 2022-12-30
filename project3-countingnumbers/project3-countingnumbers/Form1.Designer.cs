
namespace project3_countingnumbers
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtDivisibleNumbers = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioGreen = new System.Windows.Forms.RadioButton();
            this.radioBlack = new System.Windows.Forms.RadioButton();
            this.radioRed = new System.Windows.Forms.RadioButton();
            this.radioBlue = new System.Windows.Forms.RadioButton();
            this.chckBold = new System.Windows.Forms.CheckBox();
            this.chckItalic = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(137, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(801, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 69);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(466, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 61);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(953, 122);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(277, 61);
            this.textBox2.TabIndex = 3;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(336, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(277, 87);
            this.button1.TabIndex = 4;
            this.button1.Text = "Count";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(823, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(277, 87);
            this.button2.TabIndex = 5;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(137, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(495, 69);
            this.label3.TabIndex = 6;
            this.label3.Text = "Divisible Number";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(671, 261);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(303, 62);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtDivisibleNumbers
            // 
            this.txtDivisibleNumbers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtDivisibleNumbers.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDivisibleNumbers.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtDivisibleNumbers.Location = new System.Drawing.Point(0, 492);
            this.txtDivisibleNumbers.Multiline = true;
            this.txtDivisibleNumbers.Name = "txtDivisibleNumbers";
            this.txtDivisibleNumbers.Size = new System.Drawing.Size(2000, 253);
            this.txtDivisibleNumbers.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioGreen);
            this.groupBox1.Controls.Add(this.radioBlack);
            this.groupBox1.Controls.Add(this.radioRed);
            this.groupBox1.Controls.Add(this.radioBlue);
            this.groupBox1.Location = new System.Drawing.Point(1456, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 323);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Color";
            // 
            // radioGreen
            // 
            this.radioGreen.AutoSize = true;
            this.radioGreen.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioGreen.Location = new System.Drawing.Point(26, 240);
            this.radioGreen.Name = "radioGreen";
            this.radioGreen.Size = new System.Drawing.Size(158, 61);
            this.radioGreen.TabIndex = 3;
            this.radioGreen.TabStop = true;
            this.radioGreen.Text = "Green";
            this.radioGreen.UseVisualStyleBackColor = true;
            this.radioGreen.CheckedChanged += new System.EventHandler(this.radioGreen_CheckedChanged);
            // 
            // radioBlack
            // 
            this.radioBlack.AutoSize = true;
            this.radioBlack.Checked = true;
            this.radioBlack.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBlack.Location = new System.Drawing.Point(26, 173);
            this.radioBlack.Name = "radioBlack";
            this.radioBlack.Size = new System.Drawing.Size(141, 61);
            this.radioBlack.TabIndex = 2;
            this.radioBlack.TabStop = true;
            this.radioBlack.Text = "Black";
            this.radioBlack.UseVisualStyleBackColor = true;
            this.radioBlack.CheckedChanged += new System.EventHandler(this.radioBlack_CheckedChanged);
            // 
            // radioRed
            // 
            this.radioRed.AutoSize = true;
            this.radioRed.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioRed.Location = new System.Drawing.Point(26, 106);
            this.radioRed.Name = "radioRed";
            this.radioRed.Size = new System.Drawing.Size(117, 61);
            this.radioRed.TabIndex = 1;
            this.radioRed.TabStop = true;
            this.radioRed.Text = "Red";
            this.radioRed.UseVisualStyleBackColor = true;
            this.radioRed.CheckedChanged += new System.EventHandler(this.radioRed_CheckedChanged);
            // 
            // radioBlue
            // 
            this.radioBlue.AutoSize = true;
            this.radioBlue.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBlue.Location = new System.Drawing.Point(26, 39);
            this.radioBlue.Name = "radioBlue";
            this.radioBlue.Size = new System.Drawing.Size(126, 61);
            this.radioBlue.TabIndex = 0;
            this.radioBlue.TabStop = true;
            this.radioBlue.Text = "Blue";
            this.radioBlue.UseVisualStyleBackColor = true;
            this.radioBlue.CheckedChanged += new System.EventHandler(this.radioBlue_CheckedChanged);
            // 
            // chckBold
            // 
            this.chckBold.AutoSize = true;
            this.chckBold.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chckBold.Location = new System.Drawing.Point(137, 364);
            this.chckBold.Name = "chckBold";
            this.chckBold.Size = new System.Drawing.Size(109, 50);
            this.chckBold.TabIndex = 10;
            this.chckBold.Text = "Bold";
            this.chckBold.UseVisualStyleBackColor = true;
            this.chckBold.CheckedChanged += new System.EventHandler(this.chckBold_CheckedChanged);
            // 
            // chckItalic
            // 
            this.chckItalic.AutoSize = true;
            this.chckItalic.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chckItalic.Location = new System.Drawing.Point(137, 420);
            this.chckItalic.Name = "chckItalic";
            this.chckItalic.Size = new System.Drawing.Size(112, 50);
            this.chckItalic.TabIndex = 11;
            this.chckItalic.Text = "Italic";
            this.chckItalic.UseVisualStyleBackColor = true;
            this.chckItalic.CheckedChanged += new System.EventHandler(this.chckItalic_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2000, 745);
            this.Controls.Add(this.chckItalic);
            this.Controls.Add(this.chckBold);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDivisibleNumbers);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Counting Numbers";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtDivisibleNumbers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioGreen;
        private System.Windows.Forms.RadioButton radioBlack;
        private System.Windows.Forms.RadioButton radioRed;
        private System.Windows.Forms.RadioButton radioBlue;
        private System.Windows.Forms.CheckBox chckBold;
        private System.Windows.Forms.CheckBox chckItalic;
    }
}

