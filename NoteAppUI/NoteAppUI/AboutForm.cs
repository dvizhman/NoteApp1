using System.Diagnostics;
using System.Windows.Forms;

namespace NoteAppUI
{
    /// <summary>
    /// Класс формы "О программе"
    /// </summary>
    public partial class AboutForm : Form
    {
        /// <summary>
        /// Конструктор формы
        /// </summary>
        public AboutForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Запуск почтового клиента для отправки письма автору программы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabelEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("mailto:" + ((LinkLabel)sender).Text);
        }

        /// <summary>
        /// Запуск браузера для перехода в репозиторий проекта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabelGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(((LinkLabel) sender).Text);
        }
    }
}