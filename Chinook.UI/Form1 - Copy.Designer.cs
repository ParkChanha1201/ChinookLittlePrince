namespace Chinook.UI
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
            this.s = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.boxGroupBox1 = new System.Windows.Forms.GroupBox();
            this.boxGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // s
            // 
            this.s.Font = new System.Drawing.Font("Expo M", 14.25F);
            this.s.ForeColor = System.Drawing.Color.Black;
            this.s.Location = new System.Drawing.Point(212, 26);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(75, 30);
            this.s.TabIndex = 0;
            this.s.Text = "실행";
            this.s.UseVisualStyleBackColor = false;
            this.s.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.SystemColors.Window;
            this.txtInput.Font = new System.Drawing.Font("Expo M", 15F);
            this.txtInput.ForeColor = System.Drawing.Color.Black;
            this.txtInput.Location = new System.Drawing.Point(12, 27);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(194, 30);
            this.txtInput.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(170)))));
            this.textBox2.Font = new System.Drawing.Font("Expo M", 14.25F);
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(12, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(275, 29);
            this.textBox2.TabIndex = 1;
            // 
            // boxGroupBox1
            // 
            this.boxGroupBox1.AccessibleName = "";
            this.boxGroupBox1.AutoSize = true;
            this.boxGroupBox1.Controls.Add(this.txtInput);
            this.boxGroupBox1.Controls.Add(this.textBox2);
            this.boxGroupBox1.Controls.Add(this.s);
            this.boxGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxGroupBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.boxGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.boxGroupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.boxGroupBox1.MinimumSize = new System.Drawing.Size(100, 100);
            this.boxGroupBox1.Name = "boxGroupBox1";
            this.boxGroupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.boxGroupBox1.Size = new System.Drawing.Size(299, 245);
            this.boxGroupBox1.TabIndex = 2;
            this.boxGroupBox1.TabStop = false;
            this.boxGroupBox1.Text = "이름에 검색어가 포함된 아티스트의 수를 표시한다.";
            this.boxGroupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 245);
            this.Controls.Add(this.boxGroupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.boxGroupBox1.ResumeLayout(false);
            this.boxGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button s;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox boxGroupBox1;
    }
}

