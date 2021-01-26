using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp;
using NoteApp.Models;

namespace NoteAppUI
{
    /// <summary>
    /// Класс главного окна программы
    /// </summary>
    public partial class NoteForm : Form
    {
        /// <summary>
        /// Словарь категорий для отображения в программе.
        /// Сопоставление перечислимого типа и текстового представления.
        /// </summary>
        private static readonly Dictionary<Category, string> _categories = 
            new Dictionary<Category, string>()
            {
                {Category.All, "Все"},
                {Category.Work, "Работа"},
                {Category.People, "Люди"},
                {Category.Home, "Дом"},
                {Category.Health, "Здоровье"},
                {Category.Financial, "Финансы"},
                {Category.Documents, "Документы"},
                {Category.Other, "Прочее"}
            };
        
        private Project _project;
        
        /// <summary>
        /// Загрузка списка категорий заметок
        /// </summary>
        private void LoadCategories()
        {
            comboBoxCategory.DataSource = 
                new BindingSource(_categories, null);
            comboBoxCategory.DisplayMember = "Value";
            comboBoxCategory.ValueMember = "Key";
        }

        private void BindNotes()
        {
            listBoxNotes.DataSource = new BindingSource(_project.SortByDate(), null);
            listBoxNotes.DisplayMember = nameof(Note.Name);
        }
        
        /// <summary>
        /// Загрузка списка заметок
        /// </summary>
        private void LoadNotes()
        {
            _project = ProjectManager.Current.Load();
            BindNotes();
        }
        
        /// <summary>
        /// Очистка текста в label'ах и textbox'ах
        /// </summary>
        private void CleanUp()
        {
            labelName.Text = "";
            textBoxNoteText.Text = "";
        }

        /// <summary>
        /// Отображение формы "О программе"
        /// </summary>
        private void ShowAboutForm()
        {
            var aboutForm = new AboutForm();
            // Отключение активности главной формы
            Enabled = false;
            // Отображение формы "О программе"
            aboutForm.ShowDialog();
            // Включение активности главной формы
            Enabled = true;
        }

        private void SelectNote(Note note)
        {
            listBoxNotes.SelectedIndex = listBoxNotes.Items.IndexOf(note);
            labelName.Text = note.Name;
            dateTimePickerCreatedAt.Value = note.CreatedAt;
            dateTimePickerModifiedAt.Value = note.LastModifiedAt;
            textBoxNoteText.Text = note.Text;
        }
        
        /// <summary>
        /// Отображение формы редактирования заметки для её создания.
        /// </summary>
        private void AddNote()
        {
            var editForm = new NoteEditForm();
            Enabled = false;
            var result = editForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                _project.Notes.Add(editForm.Note);
                BindNotes();
                SelectNote(editForm.Note);
            }

            Enabled = true;
        }
        
        /// <summary>
        /// Конструктор главного окна программы
        /// </summary>
        public NoteForm()
        {
            InitializeComponent();
            // Очистка label'ов
            CleanUp();
            // Загрузка списка категорий
            LoadCategories();
            // Загрузка заметок
            LoadNotes();
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку "О программе"
        /// </summary>
        /// <param name="sender">Кнопка "О программе"</param>
        /// <param name="e">Аргументы события</param>
        private void toolStripMenuItemAbout_Click(object sender, EventArgs e)
        {
            // Показать форму "О программе"
            ShowAboutForm();
        }

        private void toolStripMenuItemCreate_Click(object sender, EventArgs e)
        {
            AddNote();
        }

        private void listBoxNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectNote((Note)listBoxNotes.Items[listBoxNotes.SelectedIndex]);
        }
    }
}
