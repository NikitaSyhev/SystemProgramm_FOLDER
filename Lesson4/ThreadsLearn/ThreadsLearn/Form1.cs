using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadsLearn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }
        //словарь для записи потоков в него
        Dictionary<string, Thread> threads = new Dictionary<string, Thread>();
        int n = 1;
        Form2 form;


        // создаем делегат
        public delegate void MethodContainer(string name);
        // создаем событие на основе этого делегата
        public event MethodContainer onSuspend;
        public event MethodContainer onResume;


        public void TreadForm()
        {
            form = new Form2();
            form.Text = "Поток N "+n.ToString() ;
            n++;
            onSuspend += form.Suspend;
            onResume += form.Resume;
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread=new Thread(TreadForm); thread.Start();
            thread.Name = "Поток N " + n.ToString();
            thread.IsBackground = true;
            threads.Add(thread.Name, thread);
            var i=clbTread.Items.Add(thread.Name, true);            
        }

        [Obsolete]
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (object itemChecked in clbTread.CheckedItems)
            {
                // threads[itemChecked.ToString()].Suspend();
                //мы объявили, что роизошло событие
                onSuspend(itemChecked.ToString());
            }
        }
        [Obsolete]
        private void button3_Click(object sender, EventArgs e)
        {
            foreach(object itemChecked in clbTread.CheckedItems)
            {
                //  threads[itemChecked.ToString()].Suspend();
                onResume(itemChecked.ToString());
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var thread in threads.Values)
            {
                thread.Abort();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (object itemChecked in clbTread.CheckedItems)
            {
                threads[itemChecked.ToString()].Abort();
                threads.Remove(itemChecked.ToString());
                
            }
           // clbTread.Items.Remove();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (object itemChecked in clbTread.CheckedItems)
            {
                if (threads[itemChecked.ToString()].Priority > 0) {
                    threads[itemChecked.ToString()].Priority++;
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (object itemChecked in clbTread.CheckedItems)
            {
                if (threads[itemChecked.ToString()].Priority<ThreadPriority.Highest)
                {
                    threads[itemChecked.ToString()].Priority--;
                }

            }
        }
    }
}
