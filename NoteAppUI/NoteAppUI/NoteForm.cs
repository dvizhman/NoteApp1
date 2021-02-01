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
        
        /// <summary>
        /// Объект проекта
        /// </summary>
        private Project _project = new Project();
        
        /// <summary>
        /// Загрузка списка категорий заметок
        /// </summary>
        private void LoadCategories()
        {
            // Привязка к словарю категорий
            comboBoxCategory.DataSource = 
                new BindingSource(Categories, null);
            // Отображение значения (строка)
            comboBoxCategory.DisplayMember = "Value";
            // В качестве выбранного значения выступит ключ словаря (категория)
            comboBoxCategory.ValueMember = "Key";
        }

        /// <summary>
        /// Обновление списка заметок
        /// </summary>
        /// <param name="category">Категория. Если не указана, то All.</param>
        private void BindNotes(Category category = Category.All)
        {
            // Если выбраны все категории, то получить и отобразить
            // отсортированный по дате изменения список заметок,
            // иначе отобразить отсортированный по дате изменения
            // список заметок определённой категории.
            listBoxNotes.DataSource = category == Category.All ? 
                new BindingSource(_project.SortByDate(), null) : 
                new BindingSource(_project.SortByDate(category), null);
            // Отобразить название заметки в списке заметок
            listBoxNotes.DisplayMember = nameof(Note.Name);
            // Если список заметок пуст, очистить правую часть
            if (listBoxNotes.Items.Count == 0)
            {
                CleanUp();
                SwitchEditState(false);
            }
            else
            {
                SwitchEditState(true);
            }
        }

        /// <summary>
        /// Переключение возможности редактирования и удаления заметок
        /// </summary>
        /// <param name="state">TRUE, если необходимо включить возможности</param>
        private void SwitchEditState(bool state)
        {
            buttonEdit.Enabled = state;
            buttonRemove.Enabled = state;
            toolStripMenuItemEdit.Enabled = state;
            toolStripMenuItemDelete.Enabled = state;
        }
        
        /// <summary>
        /// Загрузка списка заметок
        /// </summary>
        private void LoadNotes()
        {
            // Загрузить проект из файла
            _project = ProjectManager.Current.Load();
            // Отобразить заметки
            BindNotes();
        }
        
        /// <summary>
        /// Очистка текста в label'ах и textbox'ах
        /// </summary>
        private void CleanUp()
        {
            labelName.Text = "";
            labelNoteCategory.Text = CategoryLabel;
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
        /// Смена выбранной заметки
        /// </summary>
        /// <param name="note">Заметка</param>
        private void ChangeSelectedNote(Note note)
        {
            // Смена индекса в списке заметок
            listBoxNotes.SelectedIndex = listBoxNotes.Items.IndexOf(note);
        }
        
        /// <summary>
        /// Отображение выбранной заметки
        /// </summary>
        /// <param name="note">Выбранная заметка</param>
        private void SelectNote(Note note)
        {
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
            // Смена текущей заметки в Project
            _project.CurrentNote = note;
        }
        
        /// <summary>
        /// Отображение формы редактирования заметки для её создания.
        /// </summary>
        private void AddNote()
        {
            // Создание формы редактирования
            var editForm = new NoteEditForm();
            // Отключение данной формы
            Enabled = false;
            // Отображение формы редактирования и ожидание результата
            var result = editForm.ShowDialog();
            // Если ОК, то...
            if (result == DialogResult.OK)
            {
                // ...добавить свежесозданную заметку в список в проекте
                _project.Notes.Add(editForm.Note);
                // Смена категории
                comboBoxCategory.SelectedItem = 
                    Categories.FirstOrDefault(i => i.Key == editForm.Note.Category);
                // Обновить заметки
                BindNotes(editForm.Note.Category);
                // Сохранить проект на диск
                ProjectManager.Current.Save(_project);
                // Выбрать свежесозданную заметку
                ChangeSelectedNote(editForm.Note);
            }
            // Включение формы
            Enabled = true;
        }

        /// <summary>
        /// Отображение формы редактирования заметки для её изменения.
        /// </summary>
        private void EditNote()
        {
            // Поиск индекса выбранной заметки в списке заметок
            var selectedNote = (Note) listBoxNotes.SelectedItem;
            int index = _project.Notes.IndexOf(selectedNote);
            // Создание формы редактирования
            var editForm = new NoteEditForm(selectedNote);
            // Отключение данной формы
            Enabled = false;
            // Отображение формы редактирования и ожидание результата
            var result = editForm.ShowDialog();
            // Если ОК, то...
            if (result == DialogResult.OK)
            {
                // ...добавить свежесозданную заметку в список в проекте
                _project.Notes[index] = editForm.Note;
                // Обновить заметки
                BindNotes();
                // Сохранить проект на диск
                ProjectManager.Current.Save(_project);
                // Выбрать свежесозданную заметку
                ChangeSelectedNote(editForm.Note);
            }
            // Включение формы
            Enabled = true;
        }

        /// <summary>
        /// Удаление выбранной заметки
        /// </summary>
        private void DeleteNote()
        {
            // Поиск индекса выбранной заметки в списке заметок
            var selectedNote = (Note) listBoxNotes.SelectedItem;
            int index = _project.Notes.IndexOf(selectedNote);
            // Удаление заметок
            _project.Notes.RemoveAt(index);
            // Обновить заметки
            BindNotes();
            // Сохранить проект на диск
            ProjectManager.Current.Save(_project);
            // Если список заметок не пуст, выбрать первую
            if (listBoxNotes.Items.Count > 0)
                listBoxNotes.SelectedIndex = 0;
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
            // Выбор текущей заметки
            if (_project.CurrentNote != null)
            {
                int i = 0;
                for (i = 0; i < listBoxNotes.Items.Count; i++)
                    if (listBoxNotes.Items[i].Equals(_project.CurrentNote))
                        break;
                ChangeSelectedNote((Note)listBoxNotes.Items[i]);
            }
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку "Выход" в главном меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            Close();
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
        /// Обработчик события нажатия на кнопку "Редактировать заметку" в главном меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItemEdit_Click(object sender, EventArgs e)
        {
            EditNote();
        }
        
        /// <summary>
        /// Обработчик события нажатия на кнопку "Удалить заметку" в главном меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItemDelete_Click(object sender, EventArgs e)
        {
            DeleteNote();
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

        /// <summary>
        /// Обработчик события нажатия на кнопку "Создать заметку"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddNote();
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку "Редактировать заметку"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку "Удалить заметку"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            DeleteNote();
        }

        /// <summary>
        /// Обработчик события закрытия окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NoteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProjectManager.Current.Save(_project);
        }
    }
}
