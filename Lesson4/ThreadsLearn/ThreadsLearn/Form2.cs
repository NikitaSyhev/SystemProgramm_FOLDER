using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadsLearn
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            ChildThread = new Thread(AddProgress);
            ChildThread.IsBackground = true;    
            ChildThread.Start();
        }



        public Thread ChildThread;
        public void AddProgress()
        {
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 500000000; j++) { }


                //метод Invoke делегат
                Invoke((MethodInvoker)delegate
                {
                    pgb.Value = i;
                    lblPrc.Text = i.ToString();
                });
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            ChildThread.Abort();
        }

        public void Suspend(string name)
        {
            if (name == this.Text)
            {
                //метод приостановки потока
                ChildThread.Suspend(); 
            }
        }

        public void Resume(string name)
        {
            if (name == this.Text)
            {
                //метод приостановки потока
                var flag = ChildThread.ThreadState != ThreadState.Background;
                if (ChildThread.ThreadState != ThreadState.Running || (ChildThread.ThreadState != ThreadState.Background))
                {
                    ChildThread.Resume();
                }

              
            }
        }
    }
}
