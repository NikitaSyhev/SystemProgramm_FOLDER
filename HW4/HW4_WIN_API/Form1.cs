using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4_WIN_API
{
    public partial class Form1 : Form
    {

        //Задание 1

        [DllImport("user32.dll", CharSet = CharSet.Auto)] // подключили DLL библиотеку WIN API
        public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);


        // Задание 2
        // DLL для FindWindow
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        private const uint WM_SETTEXT = 0x000C;


        //DLL для SendMessage
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern int SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, string lParam);


        //Задание 3
        // Импортируем функции Beep и MessageBeep из библиотеки user32.dll
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool Beep(uint dwFreq, uint dwDuration);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool MessageBeep(uint uType);


        public static void ShowAboutMeInfo() // создали метод для вывода MSGBOX из WIN API
        {
            MessageBox(IntPtr.Zero, "Меня зовут Никита. Группа БВ222.", "Информация", 1);
            MessageBox(IntPtr.Zero, "Я учусь на разработчика ПО. Конкретнее, Frontend.", "Информация", 1);
           
        }


        public Form1()
        {
            InitializeComponent();
        }

      

        private void buttonTask1_Click(object sender, EventArgs e)
        {
            ShowAboutMeInfo();
        }


        private void btnFindAndSendMessage_Click_Click(object sender, EventArgs e)
        {
            // Получаем дескриптор окна по заголовку
            string windowTitle = "Заголовок окна";
            IntPtr hWnd = FindWindow(null, windowTitle);

            if (hWnd != IntPtr.Zero)
            {
                // Отправляем сообщение об изменении заголовка
                string newTitle = tbNewTitle.Text;
                SendMessage(hWnd, WM_SETTEXT, IntPtr.Zero, newTitle);

                MessageBox(IntPtr.Zero, "Сообщение успешно отправлено", "Информация", 1);
            }
            else
            {
                MessageBox(IntPtr.Zero, "Окно не найдено", "Информация", 1);
            }
        }

        private void btnBEEPsignal_Click(object sender, EventArgs e)
        {

            Beep(1000, 500); ; // Частота: 1000 Гц, Длительность: 500 миллисекунд
        }

        private void btnMSG_Beep_Signal_Click(object sender, EventArgs e)
        {
            MessageBeep(0);
        }
    }
}
