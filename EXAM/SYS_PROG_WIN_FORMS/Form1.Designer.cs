namespace SYS_PROG_WIN_FORMS
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.tbWords = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFbWords = new System.Windows.Forms.TextBox();
            this.btnAddWords = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.resultsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Выбрать набор слов";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbWords
            // 
            this.tbWords.Location = new System.Drawing.Point(12, 164);
            this.tbWords.Multiline = true;
            this.tbWords.Name = "tbWords";
            this.tbWords.Size = new System.Drawing.Size(231, 77);
            this.tbWords.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Запрещенные слова";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Поле для ввода запрещенных слов";
            // 
            // tbFbWords
            // 
            this.tbFbWords.Location = new System.Drawing.Point(346, 89);
            this.tbFbWords.Name = "tbFbWords";
            this.tbFbWords.Size = new System.Drawing.Size(276, 26);
            this.tbFbWords.TabIndex = 4;
            // 
            // btnAddWords
            // 
            this.btnAddWords.Location = new System.Drawing.Point(346, 141);
            this.btnAddWords.Name = "btnAddWords";
            this.btnAddWords.Size = new System.Drawing.Size(276, 34);
            this.btnAddWords.TabIndex = 5;
            this.btnAddWords.Text = "Добавить слово";
            this.btnAddWords.UseVisualStyleBackColor = true;
            this.btnAddWords.Click += new System.EventHandler(this.btnAddWords_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(152, 309);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(340, 99);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // resultsListBox
            // 
            this.resultsListBox.FormattingEnabled = true;
            this.resultsListBox.ItemHeight = 20;
            this.resultsListBox.Location = new System.Drawing.Point(522, 197);
            this.resultsListBox.Name = "resultsListBox";
            this.resultsListBox.Size = new System.Drawing.Size(245, 224);
            this.resultsListBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultsListBox);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnAddWords);
            this.Controls.Add(this.tbFbWords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbWords);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbWords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFbWords;
        private System.Windows.Forms.Button btnAddWords;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox resultsListBox;
    }
}

