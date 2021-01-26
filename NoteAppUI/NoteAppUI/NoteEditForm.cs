using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using NoteApp.Models;

namespace NoteAppUI
{
    /// <summary>
    /// Класс формы редактирования заметки.
    /// </summary>
    public partial class NoteEditForm : Form
    {
        /// <summary>
        /// Словарь категорий для отображения в программе.
        /// Сопоставление перечислимого типа и текстового представления.
        /// </summary>
        private static readonly Dictionary<Category, string> _categories = 
            new Dictionary<Category, string>()
            {
                {Category.Work, "Работа"},
                {Category.People, "Люди"},
                {Category.Home, "Дом"},
                {Category.Health, "Здоровье"},
                {Category.Financial, "Финансы"},
                {Category.Documents, "Документы"},
                {Category.Other, "Прочее"}
            };

        public Note Note { get; }

        private void SetUpFields()
        {
            textBox_Name.Text = Note.Name;
            comboBoxCategory.SelectedItem = _categories.
                FirstOrDefault(i => i.Key == Note.Category);
            dateTimePickerCreatedAt.Value = Note.CreatedAt;
            dateTimePickerModifiedAt.Value = Note.LastModifiedAt;
            textBox_Text.Text = Note.Text;
        }
        
        /// <summary>
        /// Загрузка списка категорий заметок
        /// </summary>
        private void LoadCategories()
        {
            comboBoxCategory.DataSource = new BindingSource(_categories, null);
            comboBoxCategory.DisplayMember = "Value";
            comboBoxCategory.ValueMember = "Key";
        }
        
        /// <summary>
        /// Конструктор формы редактирования заметки.
        /// </summary>
        public NoteEditForm()
        {
            InitializeComponent();
            LoadCategories();
            Note = new Note();
        }

        /// <summary>
        /// Конструктор формы редактирования заметки.
        /// Принимает в себя заметку для редактирования.
        /// </summary>
        /// <param name="note">Заметка для редактирования</param>
        public NoteEditForm(Note note)
        {
            InitializeComponent();
            LoadCategories();
            Note = note;
        }

        /// <summary>
        /// Событие ввода названия заметки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_Name_TextChanged(object sender, EventArgs e)
        {
            Note.Name = textBox_Name.Text;
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Note.Category = ((KeyValuePair<Category,string>)comboBoxCategory.SelectedItem).Key;
        }
        
        private void textBox_Text_TextChanged(object sender, EventArgs e)
        {
            Note.Text = textBox_Text.Text;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}