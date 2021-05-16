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
    public partial class EditForm : Form
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

        private Note _note = new Note()
        {
            Category = _categories.First().Key
        };
        
        /// <summary>
        /// Редактируемая заметка
        /// </summary>
        public Note Note
        {
            get => _note;
            set
            {
                _note = value;
                SetUpFields();
            }
        } 

        /// <summary>
        /// Первичная настройка полей формы
        /// </summary>
        private void SetUpFields()
        {
            // Название заметки
            textBox_Name.Text = Note.Name;
            // Категория заметки
            comboBoxCategory.SelectedItem = _categories.
                FirstOrDefault(i => i.Key == Note.Category);
            // Дата создания заметки
            dateTimePickerCreatedAt.Value = Note.CreatedAt;
            // Дата редактирования заметки
            dateTimePickerModifiedAt.Value = Note.LastModifiedAt;
            // Текст заметки
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
        public EditForm()
        {
            
            InitializeComponent();
            // Загрузка списка категорий
            LoadCategories();
            // Первичная настройка полей
            SetUpFields();
        }

        /// <summary>
        /// Событие ввода названия заметки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_Name_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Note.Name = textBox_Name.Text;
                Note.SetModified();
                errorProvider.SetError((TextBox)sender, "");
                buttonOk.Enabled = true;
            }
            catch (ArgumentException ex)
            {
                errorProvider.SetError((TextBox)sender, ex.Message);
                buttonOk.Enabled = false;
            }
        }

        /// <summary>
        /// Событие смены категории заметки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Note.Category = ((KeyValuePair<Category,string>)comboBoxCategory.SelectedItem).Key;
            Note.SetModified();
        }
        
        /// <summary>
        /// Событие изменения текста заметки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_Text_TextChanged(object sender, EventArgs e)
        {
            Note.Text = textBox_Text.Text;
            Note.SetModified();
        }

        /// <summary>
        /// Событие нажатия кнопки "OK"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Событие нажатия кнопки "Отмена"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}