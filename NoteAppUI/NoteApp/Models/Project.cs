using System.Collections.Generic;
using System.Linq;

namespace NoteApp.Models
{
    /// <summary>
    /// Класс проекта заметок
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Список заметок
        /// </summary>
        public List<Note> Notes { get; set; } = new List<Note>();

        /// <summary>
        /// Сортировка заметок по дате изменения.
        /// От новых к старым.
        /// </summary>
        /// <returns>Отсортированный по убыванию даты список заметок</returns>
        public List<Note> SortByDate()
        {
            return Notes.
                OrderByDescending(i => i.LastModifiedAt).
                ToList();
        }

        /// <summary>
        /// Сортировка заметок конкретной категории по дате изменения.
        /// От новых к старым.
        /// </summary>
        /// <param name="category">Категория заметок</param>
        /// <returns>Отсортированный по убыванию даты список заметок выбранной категории</returns>
        public List<Note> SortByDate(Category category)
        {
            return Notes.
                Where(i => i.Category == category).
                OrderByDescending(k => k.LastModifiedAt).
                ToList();
        }
    }
}