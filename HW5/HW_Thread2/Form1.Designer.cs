namespace HW_Thread2
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
            this.listBoxProcesses = new System.Windows.Forms.ListBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSTOP = new System.Windows.Forms.Button();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxProcesses
            // 
            this.listBoxProcesses.FormattingEnabled = true;
            this.listBoxProcesses.ItemHeight = 20;
            this.listBoxProcesses.Location = new System.Drawing.Point(26, 179);
            this.listBoxProcesses.Name = "listBoxProcesses";
            this.listBoxProcesses.Size = new System.Drawing.Size(727, 144);
            this.listBoxProcesses.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(26, 34);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(191, 72);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSTOP
            // 
            this.btnSTOP.Location = new System.Drawing.Point(562, 34);
            this.btnSTOP.Name = "btnSTOP";
            this.btnSTOP.Size = new System.Drawing.Size(191, 72);
            this.btnSTOP.TabIndex = 2;
            this.btnSTOP.Text = "STOP";
            this.btnSTOP.UseVisualStyleBackColor = true;
            this.btnSTOP.Click += new System.EventHandler(this.btnSTOP_Click);
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(296, 80);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(189, 26);
            this.txtInterval.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Интервал, сек";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 341);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInterval);
            this.Controls.Add(this.btnSTOP);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.listBoxProcesses);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProcesses;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSTOP;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.Label label1;
    }
}

