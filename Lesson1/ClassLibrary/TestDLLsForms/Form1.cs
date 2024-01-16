using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary; // подключили стронний класс, который создали сами


namespace TestDLLsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MyMath.IsLeap(Msg.Text))
                ClassLibrary.Message.GetMessage("Високосный");
            else
                ClassLibrary.Message.GetMessage("Не високосный"); ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var d=MyMath.Max(Msg.Text);
        }
    }
}
