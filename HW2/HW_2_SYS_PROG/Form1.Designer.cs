namespace HW_2_SYS_PROG
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
            this.tbNum1 = new System.Windows.Forms.TextBox();
            this.tbNum2 = new System.Windows.Forms.TextBox();
            this.blNum1 = new System.Windows.Forms.Label();
            this.lbNum2 = new System.Windows.Forms.Label();
            this.btnGen = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.btnFbn = new System.Windows.Forms.Button();
            this.tbFib = new System.Windows.Forms.TextBox();
            this.btnStop1 = new System.Windows.Forms.Button();
            this.btnStop2 = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.btnResume2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNum1
            // 
            this.tbNum1.Location = new System.Drawing.Point(61, 97);
            this.tbNum1.Name = "tbNum1";
            this.tbNum1.Size = new System.Drawing.Size(100, 20);
            this.tbNum1.TabIndex = 0;
            // 
            // tbNum2
            // 
            this.tbNum2.Location = new System.Drawing.Point(61, 150);
            this.tbNum2.Name = "tbNum2";
            this.tbNum2.Size = new System.Drawing.Size(100, 20);
            this.tbNum2.TabIndex = 1;
            // 
            // blNum1
            // 
            this.blNum1.AutoSize = true;
            this.blNum1.Location = new System.Drawing.Point(58, 81);
            this.blNum1.Name = "blNum1";
            this.blNum1.Size = new System.Drawing.Size(48, 13);
            this.blNum1.TabIndex = 2;
            this.blNum1.Text = "Число 1";
            // 
            // lbNum2
            // 
            this.lbNum2.AutoSize = true;
            this.lbNum2.Location = new System.Drawing.Point(58, 134);
            this.lbNum2.Name = "lbNum2";
            this.lbNum2.Size = new System.Drawing.Size(48, 13);
            this.lbNum2.TabIndex = 3;
            this.lbNum2.Text = "Число 2";
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(221, 71);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(97, 49);
            this.btnGen.TabIndex = 4;
            this.btnGen.Text = "Сгенерировать";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(362, 71);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(100, 73);
            this.textBox.TabIndex = 5;
            // 
            // btnFbn
            // 
            this.btnFbn.Location = new System.Drawing.Point(218, 205);
            this.btnFbn.Name = "btnFbn";
            this.btnFbn.Size = new System.Drawing.Size(97, 59);
            this.btnFbn.TabIndex = 6;
            this.btnFbn.Text = "Сгенерировать Фибонначи";
            this.btnFbn.UseVisualStyleBackColor = true;
            this.btnFbn.Click += new System.EventHandler(this.btnFbn_Click);
            // 
            // tbFib
            // 
            this.tbFib.Location = new System.Drawing.Point(218, 270);
            this.tbFib.Multiline = true;
            this.tbFib.Name = "tbFib";
            this.tbFib.Size = new System.Drawing.Size(100, 73);
            this.tbFib.TabIndex = 7;
            // 
            // btnStop1
            // 
            this.btnStop1.Location = new System.Drawing.Point(618, 76);
            this.btnStop1.Name = "btnStop1";
            this.btnStop1.Size = new System.Drawing.Size(139, 68);
            this.btnStop1.TabIndex = 8;
            this.btnStop1.Text = "Stop Thread 1";
            this.btnStop1.UseVisualStyleBackColor = true;
            this.btnStop1.Click += new System.EventHandler(this.btnStop1_Click);
            // 
            // btnStop2
            // 
            this.btnStop2.Location = new System.Drawing.Point(618, 255);
            this.btnStop2.Name = "btnStop2";
            this.btnStop2.Size = new System.Drawing.Size(139, 68);
            this.btnStop2.TabIndex = 9;
            this.btnStop2.Text = "Stop Thread 2";
            this.btnStop2.UseVisualStyleBackColor = true;
            this.btnStop2.Click += new System.EventHandler(this.btnStop2_Click);
            // 
            // btnResume
            // 
            this.btnResume.Location = new System.Drawing.Point(618, 150);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(139, 68);
            this.btnResume.TabIndex = 10;
            this.btnResume.Text = "Resume Thread 1";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnResume2
            // 
            this.btnResume2.Location = new System.Drawing.Point(618, 329);
            this.btnResume2.Name = "btnResume2";
            this.btnResume2.Size = new System.Drawing.Size(139, 68);
            this.btnResume2.TabIndex = 11;
            this.btnResume2.Text = "Resume Thread 2";
            this.btnResume2.UseVisualStyleBackColor = true;
            this.btnResume2.Click += new System.EventHandler(this.btnResume2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnResume2);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.btnStop2);
            this.Controls.Add(this.btnStop1);
            this.Controls.Add(this.tbFib);
            this.Controls.Add(this.btnFbn);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.lbNum2);
            this.Controls.Add(this.blNum1);
            this.Controls.Add(this.tbNum2);
            this.Controls.Add(this.tbNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNum1;
        private System.Windows.Forms.TextBox tbNum2;
        private System.Windows.Forms.Label blNum1;
        private System.Windows.Forms.Label lbNum2;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button btnFbn;
        private System.Windows.Forms.TextBox tbFib;
        private System.Windows.Forms.Button btnStop1;
        private System.Windows.Forms.Button btnStop2;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Button btnResume2;
    }
}

