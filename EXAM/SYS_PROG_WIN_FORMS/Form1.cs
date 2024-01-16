using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYS_PROG_WIN_FORMS
{
    public partial class Form1 : Form
    {

        List<string> forbiddenWords = new List<string>(); //глобальная переменная для сохранения списка запрещенных слов
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // создали обработчик событий для открытия файла
        {
            OpenFile();
        }

        private void OpenFile() //открываем файл с запрещенными словами
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //получили путь к файлу
                    var filePath = openFileDialog1.FileName;
                    using (Stream str = openFileDialog1.OpenFile())
                    {
                        Process.Start("notepad.exe", filePath);


                    }
                    //сохранили весь текст в переменную
                    string fileContent = File.ReadAllText(filePath);

                    //скачиваем слова в массив
                    char[] separators = { ' ', '\t', '\n', '.', ',' };
                    //появился массив запрещенных слов
                    string[] words = fileContent.Split(new char[] { ' ', ',', '.', ';' }, StringSplitOptions.RemoveEmptyEntries);
                    forbiddenWords.Add(words[0]);
                    foreach (var word in forbiddenWords)
                    {
                        //вывели запрещенные слова в текст бокс
                        tbWords.Text = word.ToString();
                    }
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }    // 

        private void btnAddWords_Click(object sender, EventArgs e) //обработчик событий для указания запрещенных слов через Text Box
        {
            AddWordsToList();
        }

        private void AddWordsToList() //добавляем слово из текстбокса в ЛИСТ
        {
            string forbidenWord = tbFbWords.Text;
            forbiddenWords.Add(forbidenWord);
            foreach (var word in forbiddenWords)
            {
                //вывели запрещенные слова в текст бокс
                tbWords.Text = word.ToString();
            }
        }

        private void btnStart_Click(object sender, EventArgs e) //метод поиска запрещенных слов на всех накопителях
        {
            SearchWordsOnLaptop();
        }

        private void SearchWordsInDirectory(string directoryPath)
        {
            
            string[] files = Directory.GetFiles(directoryPath); //список всех файлов в текущем каталоге
            foreach (var file in files)
            { 
                string fileContent = File.ReadAllText(file);//считываем весь текст и сохраняем в строку
                foreach (var word in forbiddenWords) // идем по списку запрещенных слов
                {
                    if(fileContent.Contains(word)) //если весь текст в каталоге содержит запр слово - выводим в лист бокс
                    {
                        resultsListBox.Items.Add($"Нашли слово {word} в файле: {file}");
                        //копирование
                        string pathCopy = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Debug", Path.GetFileName(file));//AppDomain.CurrentDomain.BaseDirectory: - текущая директория
                        //"Debug" - имя папки, мы копируем в ДЕБАГ, 
                        File.Copy(file, pathCopy, true);// метод копирования из одного пути в другой

                        //создание файла отчета
                        
                    }
                }
            }

        }

        private void SearchWordsOnLaptop()
        {
            // Получаем все логические диски на компьютере
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            // Очищаем ListBox перед новым поиском
            resultsListBox.Items.Clear();

            // Проходим по каждому диску
            foreach (DriveInfo drive in allDrives)
            {
                // Если диск доступен для чтения
                if (drive.IsReady)
                {
                    // Запускаем  поиск на диске
                    SearchWordsInDirectory(drive.RootDirectory.FullName);
                }
            }

            if (resultsListBox.Items.Count == 0)
            {
                resultsListBox.Items.Add("Ничего не найдено.");
            }
        }
    }

    



}
