using System;
using System.IO;
using System.Windows.Forms;

namespace Install
{
    public partial class InstallField : Form
    {
        public InstallField()
        {
            InitializeComponent();
        }

        private string folderName = @"C:\"; // путь до установки программы, по умолчанию C://
        private byte pages; // страницы

        private void btn_read_Click(object sender, EventArgs e)
        {
            // показать диалог выбора папки
            DialogResult result = folderBrowserDialog.ShowDialog();

            // если папка выбрана и нажата клавиша `OK` - значит можно получить путь к папке
            if (result == DialogResult.OK)
            {
                // запишем в нашу переменную путь к папке
                folderName = folderBrowserDialog.SelectedPath;
                // вывод путя в label
                l_path.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void InstallField_Load(object sender, EventArgs e)
        {
            l_title.Text = "Вас приветствует мастер установки ПО";
            l_text.Text = "Программа \"SergFras - launcher\" будет установлена на ваш пк \nс помощью InstallShield SergFras";

            // скрытие всех объектов на главной странице
            l_path.Visible = false;
            btn_read.Visible = false;
            btn_cancel.Visible = false;
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            pages++;

            if (pages == 1) // первая страница
            {
                l_title.Text = "Установщик ПО";
                l_text.Text = "Выберите путь для установки программы.";

                // показ всех объектов на первой странице
                l_path.Visible = true;
                btn_read.Visible = true;
                btn_cancel.Visible = true;

                btn_next.Text = "Установить";
            }
            if (pages == 2) // вторая страница
            {
                l_text.Text = "Идёт установка...";

                // скрытие всех объектов на второй странице
                btn_cancel.Visible = false;
                l_path.Visible = false;
                btn_read.Visible = false;

                string path = @"data";

                if (new DirectoryInfo(path).Exists)
                    new DirectoryInfo(path).MoveTo(folderName + @"\launcher"); // добавление директории launcher, в нём будут находится остальные файлы
                else
                    MessageBox.Show("Не обнаружено файлов для установки!\nПроверьте целостность файлов", "Ошибка");

                btn_next.Text = "Завершить";
                l_text.Text = "Спасибо за установку нашего ПО.";
            }
            if (pages == 3) // третья страница (для кнопки завершить - выход из программы)
                this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            pages--;

            if (pages == 0) // для кнопки отмена(страницы идёт в обратном порядке)
            {
                // возвращение в исходное состояние(главная страница)
                l_title.Text = "Вас приветствует мастер установки ПО";
                l_text.Text = "Программа \"SergFras - launcher\" будет установлена на ваш пк \nс помощью InstallShield SergFras";

                l_path.Visible = false;
                btn_read.Visible = false;
                btn_cancel.Visible = false;

                btn_next.Text = "Далее";
            }
        }
    }
}
