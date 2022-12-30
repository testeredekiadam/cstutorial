
namespace Project12_polymorph
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
            this.btn1Parameter = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn2Parameter = new System.Windows.Forms.Button();
            this.btn4Parameters = new System.Windows.Forms.Button();
            this.btn3Parameter = new System.Windows.Forms.Button();
            this.overrideButton = new System.Windows.Forms.Button();
            this.virtualButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1Parameter
            // 
            this.btn1Parameter.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn1Parameter.Location = new System.Drawing.Point(695, 12);
            this.btn1Parameter.Name = "btn1Parameter";
            this.btn1Parameter.Size = new System.Drawing.Size(233, 59);
            this.btn1Parameter.TabIndex = 0;
            this.btn1Parameter.Text = "1 Parameter";
            this.btn1Parameter.UseVisualStyleBackColor = true;
            this.btn1Parameter.Click += new System.EventHandler(this.btn1Parameter_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(408, 400);
            this.textBox1.TabIndex = 1;
            // 
            // btn2Parameter
            // 
            this.btn2Parameter.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn2Parameter.Location = new System.Drawing.Point(695, 108);
            this.btn2Parameter.Name = "btn2Parameter";
            this.btn2Parameter.Size = new System.Drawing.Size(233, 59);
            this.btn2Parameter.TabIndex = 2;
            this.btn2Parameter.Text = "2 Parameters";
            this.btn2Parameter.UseVisualStyleBackColor = true;
            this.btn2Parameter.Click += new System.EventHandler(this.btn2Parameter_Click);
            // 
            // btn4Parameters
            // 
            this.btn4Parameters.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn4Parameters.Location = new System.Drawing.Point(695, 307);
            this.btn4Parameters.Name = "btn4Parameters";
            this.btn4Parameters.Size = new System.Drawing.Size(233, 59);
            this.btn4Parameters.TabIndex = 4;
            this.btn4Parameters.Text = "4 Parameter";
            this.btn4Parameters.UseVisualStyleBackColor = true;
            this.btn4Parameters.Click += new System.EventHandler(this.btn4Parameters_Click);
            // 
            // btn3Parameter
            // 
            this.btn3Parameter.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn3Parameter.Location = new System.Drawing.Point(695, 204);
            this.btn3Parameter.Name = "btn3Parameter";
            this.btn3Parameter.Size = new System.Drawing.Size(233, 59);
            this.btn3Parameter.TabIndex = 3;
            this.btn3Parameter.Text = "3 Parameter";
            this.btn3Parameter.UseVisualStyleBackColor = true;
            this.btn3Parameter.Click += new System.EventHandler(this.btn3Parameter_Click);
            // 
            // overrideButton
            // 
            this.overrideButton.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.overrideButton.Location = new System.Drawing.Point(441, 204);
            this.overrideButton.Name = "overrideButton";
            this.overrideButton.Size = new System.Drawing.Size(233, 59);
            this.overrideButton.TabIndex = 6;
            this.overrideButton.Text = "Override";
            this.overrideButton.UseVisualStyleBackColor = true;
            this.overrideButton.Click += new System.EventHandler(this.overrideButton_Click);
            // 
            // virtualButton
            // 
            this.virtualButton.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.virtualButton.Location = new System.Drawing.Point(441, 108);
            this.virtualButton.Name = "virtualButton";
            this.virtualButton.Size = new System.Drawing.Size(233, 59);
            this.virtualButton.TabIndex = 5;
            this.virtualButton.Text = "Virtual";
            this.virtualButton.UseVisualStyleBackColor = true;
            this.virtualButton.Click += new System.EventHandler(this.virtualButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 450);
            this.Controls.Add(this.overrideButton);
            this.Controls.Add(this.virtualButton);
            this.Controls.Add(this.btn4Parameters);
            this.Controls.Add(this.btn3Parameter);
            this.Controls.Add(this.btn2Parameter);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn1Parameter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1Parameter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn2Parameter;
        private System.Windows.Forms.Button btn4Parameters;
        private System.Windows.Forms.Button btn3Parameter;
        private System.Windows.Forms.Button overrideButton;
        private System.Windows.Forms.Button virtualButton;
    }
}

