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


// НЕ ЗНАЮ, КАК СДЕЛАТЬ ТАК, ЧТОБЫ ЕСЛИ ТЕКСТ БОКС ПУСТОЙ, ТО ПОТОК НАЧИНАЛСЯ с 2

namespace HW_2_SYS_PROG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        
            
        }

        int num1, num2;
        Thread thread2; //поток для Фибоначчи
        Thread thread1; // поток для диапазона чисел
      

        private void btnGen_Click(object sender, EventArgs e)
        {
            thread1 = new Thread(genereteNumbers);
            thread1.Start();
        }

        private void btnFbn_Click(object sender, EventArgs e)
        {
            thread2 = new Thread(generateFibbonachi);
            thread2.Start();
        }

        private void generateFibbonachi() // метод для генерации чисел Фибоначи ( колбэк функция ) 
        {
            try
            {
                num1 = Convert.ToInt32(tbNum1.Text);
                num2 = Convert.ToInt32(tbNum2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Введите числа");

            }

            int num = 1;
            int j = num;
            tbFib.Text = "";
            //вывели числа Фибоначи в цикле, начало 1, конеч цикла, второе число, которое ввел пользователь
            for (int i = num; i <= num2; i += j)
            {
                tbFib.Text += i + " ";
                j = i - j;

            }
        }

        private void btnStop1_Click(object sender, EventArgs e) //остановка потока
        {
            thread1.Abort();
        }

        private void btnStop2_Click(object sender, EventArgs e)
        {
            thread2.Abort();
        }

        [Obsolete]
        private void btnResume_Click(object sender, EventArgs e)
        {
            thread1.Resume();
        }
        [Obsolete]
        private void btnResume2_Click(object sender, EventArgs e)
        {
            thread2.Resume();
        }

        private void genereteNumbers()  // (колбэк функция ) мы ее пробросим в создание потока 
        {
            //считали введенные числа в переменные
            try
            {
                num1 = Convert.ToInt32(tbNum1.Text);
                num2 = Convert.ToInt32(tbNum2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Введите числа");

            }
            textBox.Text = "";
            //вывести все числа в тексбокс
            for (int i = num1; i <= num2; ++i) // логика такая, что для каждой итерации создается поток
            {
                textBox.Text += $"Число: {i}.\r\n";
            }
        }
    }
}
