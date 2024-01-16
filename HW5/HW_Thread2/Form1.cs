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
using System.Diagnostics;
using Timer = System.Windows.Forms.Timer;

namespace HW_Thread2
{
    public partial class Form1 : Form
    {
        private Timer timer; // создали объект Timer, для обновления списка процессов
        public Form1()
        {
            InitializeComponent();
            InitializeTimer(); //инициализировали Timer
            MessageBox.Show("Укажите интервал для обновления, секунды."); // инструкция для пользователя
        }
        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 1000; // Устанавливаем интервал таймера в миллисекундах (в данном случае, 1 секунда)
            timer.Tick += Timer_Tick;
        }
        private void Timer_Tick(object sender, EventArgs e) //вызывает обновление при каждом тике таймера
        {
            RefreshProcessList();
        }
        private void RefreshProcessList() // обновляет список процессов и отображает их в ListBox
        {
            listBoxProcesses.Items.Clear(); // очистили список

            Process[] processes = Process.GetProcesses(); // предоставляет массив процессов
            foreach (Process process in processes) // пробегаем циклом по массиву процессов и записываем в листбокс
            {
                listBoxProcesses.Items.Add($"{process.ProcessName} (ID: {process.Id})");
            }
        }

        private void btnStart_Click(object sender, EventArgs e) // метод запуска
        {
            int interval; // пользователь указывает интервал

            if (int.TryParse(txtInterval.Text, out interval)) // out interval показывает, в какую переменную мы сохраняем результат TryParse
            {
                // Проверка на положительный интервал
                if (interval > 0)
                {
                    timer.Interval = interval * 1000; // Переводим интервал в миллисекунды
                    timer.Start();
                    RefreshProcessList();
                    MessageBox.Show($"Обновление списка процессов каждые {interval} секунд.", "Старт таймера", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Интервал должен быть положительным числом.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Некорректный ввод. Пожалуйста, введите целое положительное число для интервала.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSTOP_Click(object sender, EventArgs e)
        {
            timer.Stop();
            MessageBox.Show("Таймер остановлен.", "Стоп таймера", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop(); // Останавливаем таймер перед закрытием формы
        }
    }
    }

