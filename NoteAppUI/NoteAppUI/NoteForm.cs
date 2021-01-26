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
        private const string CategoryLabel = "Категория: ";
        
        /// <summary>
        /// Словарь категорий для отображения в программе.
        /// Сопоставление перечислимого типа и текстового представления.
        /// </summary>
        private static readonly Dictionary<Category, string> Categories = 
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
                new BindingSource(Categories, null);
            comboBoxCategory.DisplayMember = "Value";
            comboBoxCategory.ValueMember = "Key";
        }

        private void BindNotes(Category category = Category.All)
        {
            listBoxNotes.DataSource = category == Category.All ? 
                new BindingSource(_project.SortByDate(), null) : 
                new BindingSource(_project.SortByDate(category), null);
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

        /// <summary>
        /// Отображение выбранной заметки
        /// </summary>
        /// <param name="note">Выбранная заметка</param>
        private void SelectNote(Note note)
        {
            // Смена индекса в списке заметок
            listBoxNotes.SelectedIndex = listBoxNotes.Items.IndexOf(note);
            // Смена названия
            labelName.Text = note.Name;
            // Смена отображаемой категории
            labelNoteCategory.Text = CategoryLabel + Categories[note.Category];
            // Смена даты создания заметки
            dateTimePickerCreatedAt.Value = note.CreatedAt;
            // Смена даты изменения заметки
            dateTimePickerModifiedAt.Value = note.LastModifiedAt;
            // Смена текста заметки
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
                ProjectManager.Current.Save(_project);
                SelectNote(editForm.Note);
            }
            Enabled = true;
        }

        private void EditNote()
        {
            var selectedNote = (Note) listBoxNotes.SelectedItem;
            int index = _project.Notes.IndexOf(selectedNote);
            var editForm = new NoteEditForm(selectedNote);
            Enabled = false;
            var result = editForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                _project.Notes[index] = editForm.Note;
                BindNotes();
                ProjectManager.Current.Save(_project);
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

        /// <summary>
        /// Обработчик события нажатия на кнопку "Создать заметку" в главном меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItemCreate_Click(object sender, EventArgs e)
        {
            AddNote();
        }

        /// <summary>
        /// Обработчик события смены выбранной заметки в списке заметок
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Отобразить выбранную заметку
            SelectNote((Note)listBoxNotes.Items[listBoxNotes.SelectedIndex]);
        }

        /// <summary>
        /// Обработчик события смены категории отображаемых заметок
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Заново сформировать список из заметок только выбранной категории
            BindNotes(((KeyValuePair<Category,string>)comboBoxCategory.SelectedItem).Key);
        }

        private void toolStripMenuItemEdit_Click(object sender, EventArgs e)
        {
            EditNote();
        }
    }
}
