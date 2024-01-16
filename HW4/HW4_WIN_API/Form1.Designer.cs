namespace HW4_WIN_API
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
            this.buttonTask1 = new System.Windows.Forms.Button();
            this.btnFindAndSendMessage_Click = new System.Windows.Forms.Button();
            this.tbNewTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBEEPsignal = new System.Windows.Forms.Button();
            this.btnMSG_Beep_Signal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTask1
            // 
            this.buttonTask1.Location = new System.Drawing.Point(154, 0);
            this.buttonTask1.Name = "buttonTask1";
            this.buttonTask1.Size = new System.Drawing.Size(134, 79);
            this.buttonTask1.TabIndex = 0;
            this.buttonTask1.Text = "TASK1";
            this.buttonTask1.UseVisualStyleBackColor = true;
            this.buttonTask1.Click += new System.EventHandler(this.buttonTask1_Click);
            // 
            // btnFindAndSendMessage_Click
            // 
            this.btnFindAndSendMessage_Click.Location = new System.Drawing.Point(496, 0);
            this.btnFindAndSendMessage_Click.Name = "btnFindAndSendMessage_Click";
            this.btnFindAndSendMessage_Click.Size = new System.Drawing.Size(137, 79);
            this.btnFindAndSendMessage_Click.TabIndex = 1;
            this.btnFindAndSendMessage_Click.Text = "TASK2";
            this.btnFindAndSendMessage_Click.UseVisualStyleBackColor = true;
            this.btnFindAndSendMessage_Click.Click += new System.EventHandler(this.btnFindAndSendMessage_Click_Click);
            // 
            // tbNewTitle
            // 
            this.tbNewTitle.Location = new System.Drawing.Point(496, 140);
            this.tbNewTitle.Multiline = true;
            this.tbNewTitle.Name = "tbNewTitle";
            this.tbNewTitle.Size = new System.Drawing.Size(174, 42);
            this.tbNewTitle.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(492, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Заголовок. Задание 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Звуковые сигналы";
            // 
            // btnBEEPsignal
            // 
            this.btnBEEPsignal.Location = new System.Drawing.Point(154, 292);
            this.btnBEEPsignal.Name = "btnBEEPsignal";
            this.btnBEEPsignal.Size = new System.Drawing.Size(134, 79);
            this.btnBEEPsignal.TabIndex = 5;
            this.btnBEEPsignal.Text = "BEEP";
            this.btnBEEPsignal.UseVisualStyleBackColor = true;
            this.btnBEEPsignal.Click += new System.EventHandler(this.btnBEEPsignal_Click);
            // 
            // btnMSG_Beep_Signal
            // 
            this.btnMSG_Beep_Signal.Location = new System.Drawing.Point(367, 292);
            this.btnMSG_Beep_Signal.Name = "btnMSG_Beep_Signal";
            this.btnMSG_Beep_Signal.Size = new System.Drawing.Size(134, 79);
            this.btnMSG_Beep_Signal.TabIndex = 6;
            this.btnMSG_Beep_Signal.Text = "MessageBEEP";
            this.btnMSG_Beep_Signal.UseVisualStyleBackColor = true;
            this.btnMSG_Beep_Signal.Click += new System.EventHandler(this.btnMSG_Beep_Signal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 425);
            this.Controls.Add(this.btnMSG_Beep_Signal);
            this.Controls.Add(this.btnBEEPsignal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNewTitle);
            this.Controls.Add(this.btnFindAndSendMessage_Click);
            this.Controls.Add(this.buttonTask1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTask1;
        private System.Windows.Forms.Button btnFindAndSendMessage_Click;
        private System.Windows.Forms.TextBox tbNewTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBEEPsignal;
        private System.Windows.Forms.Button btnMSG_Beep_Signal;
    }
}

