using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;



namespace System_Programm_Lesson3   
{
    public partial class Form1 : Form
    {
       static int timerCount = 0;
        System.Threading.Timer timer;

       


        public Form1()
        {
            InitializeComponent();
        }

        //CallBack функция
        public static void TimerMethod(object sender)
        {
            //textBox1.Text += "сработал" + "/r/n";
            timerCount++;
            MessageBox.Show("As");
            if (timerCount > 5) (sender as System.Threading.Timer).Dispose();

        }

        public static void ThreadMethod()
        {
            TimerCallback timerCallback = new TimerCallback(TimerMethod);
            timerCount = 0;
            System.Threading.Timer timer = new System.Threading.Timer(timerCallback);
            timer.Change(1000, 1000);

        }

        // создали делегат для метода TimerMethod
        TimerCallback timerCallback = new TimerCallback(TimerMethod);
        //создали делегат для ThreadMethod
        ThreadStart timeStart = new ThreadStart(ThreadMethod);


        private void button1_Click(object sender, EventArgs e)
        {
            timer = new System.Threading.Timer(timerCallback);
            timer.Change(1000, 1000);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Dispose();
        }


        //создаем потоки
        Thread thread;


        // в этом методе мы используем делегат timeStart, делегат обращается к методу ThreadMethod
        // т.е. в собитии мы используем делегат, который обращается к методу ThreadMethod
        private void button3_Click(object sender, EventArgs e)
        {
            thread = new Thread(timeStart);
            thread.Start();
        }


        public static void ThreadMetod(object sender)
        {

           
            
            for (int i = 0; i < 100; i++)
                (sender as TextBox).Text += "поток" + DateTime.Now.Millisecond+" " + Convert.ToString(i) + "\r\n";

        }

        //делегат, который требует метод ThreadMethod
        ParameterizedThreadStart threadStart = new ParameterizedThreadStart(ThreadMetod);

        // олбъявили поток номер 2
        Thread thread1;

        //выводим сообщения из поток 1 в месседжбокс 1 и из потока 2 в месседжбокс 2
        private void button4_Click(object sender, EventArgs e)
        {
            thread = new Thread(threadStart);
            thread.Start((object)textBox1);
            thread1 = new Thread(threadStart);
            thread1.Start((object)textBox2);
        }
    }
}
