using System;

namespace NoteApp.Models
{
    /// <summary>
    /// Класс заметки
    /// </summary>
    public class Note : ICloneable, IEquatable<Note>
    {
        /// <summary>
        /// Поле имени заметки
        /// </summary>
        private string _name = "Без названия";

        /// <summary>
        /// Поле категории заметки
        /// </summary>
        private Category _category;

        /// <summary>
        /// Поле текстового содержимого заметки
        /// </summary>
        private string _text = "";

        /// <summary>
        /// Поле даты создания заметки
        /// </summary>
        private DateTime _createdAt = DateTime.Now;
        
        /// <summary>
        /// Поле даты последнего изменения заметки.
        /// </summary>
        private DateTime _lastModifiedAt = DateTime.Now;

        /// <summary>
        /// Свойство названия заметки.
        /// </summary>
        /// <exception cref="NullReferenceException">Выбрасывается в случае, 
        /// если название заметки равно null.</exception>
        /// <exception cref="ArgumentException">Выбрасывается в случае, 
        /// если название длиннее 50 символов.</exception>
        public string Name
        {
            get => _name;
            set
            {
                // Проверка на null
                if (value == null)
                    throw new NullReferenceException("Название заметки равно null.");
                // Проверка на длину
                if (value.Length > 50)
                    throw new ArgumentException("Название заметки превышает 50 символов");
                _name = value;
            }
        }

        /// <summary>
        /// Свойство категории заметки.
        /// </summary>
        public Category Category
        {
            get => _category;
            set => _category = value;
        }

        /// <summary>
        /// Свойство текста заметки.
        /// </summary>
        /// <exception cref="NullReferenceException">Выбрасывается, если текст равен null.</exception>
        public string Text
        {
            get => _text;
            set =>
                // Проверка на null
                _text = value ?? 
                        throw new NullReferenceException("Текст заметки равен null.");
        }

        /// <summary>
        /// Свойство даты создания заметки.
        /// </summary>
        public DateTime CreatedAt {
            get => _createdAt;
            // Сеттер используется для десериализации
            set => _createdAt = value;
        }

        /// <summary>
        /// Свойство даты последнего изменения заметки.
        /// </summary>
        public DateTime LastModifiedAt
        {
            get => _lastModifiedAt;
            // Сеттер используется для десериализации
            set => _lastModifiedAt = value;
        }

        /// <summary>
        /// Метод изменяет дату изменения заметки на текущую
        /// </summary>
        public void SetModified()
        {
            LastModifiedAt = DateTime.Now;
        }
        
        /// <summary>
        /// Клонирует объект заметки
        /// </summary>
        /// <returns>Клон объекта Note</returns>
        public object Clone()
        {
            return new Note()
            {
                _createdAt = this._createdAt,
                _category = this._category,
                _name = this._name,
                _text = this._text,
                _lastModifiedAt = this._lastModifiedAt
            };
        }

        public bool Equals(Note other)
        {
            if (other == null)
                return false;
            return
                CreatedAt == other.CreatedAt &&
                Category == other.Category &&
                Name == other.Name &&
                Text == other.Text &&
                LastModifiedAt == other.LastModifiedAt;
        }
    }
}