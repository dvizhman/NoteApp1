using System;
using System.Net.Configuration;
using Newtonsoft.Json;

namespace NoteApp.Models
{
    /// <summary>
    /// Класс заметки
    /// </summary>
    public class Note : ICloneable
    {
        /// <summary>
        /// Поле имени заметки
        /// </summary>
        [JsonProperty("name")]
        private string _name = "Без названия";

        /// <summary>
        /// Поле категории заметки
        /// </summary>
        [JsonProperty("category")]
        private Category _category;

        /// <summary>
        /// Поле текстового содержимого заметки
        /// </summary>
        [JsonProperty("text")]
        private string _text = "";

        /// <summary>
        /// Поле даты создания заметки
        /// </summary>
        [JsonProperty("createdAt")]
        private DateTime _createdAt = DateTime.Now;
        
        /// <summary>
        /// Поле даты последнего изменения заметки.
        /// </summary>
        [JsonProperty("lastModifiedAt")]
        private DateTime _lastModifiedAt = DateTime.Now;

        /// <summary>
        /// Свойство названия заметки.
        /// </summary>
        /// <exception cref="NullReferenceException">Выбрасывается в случае, 
        /// если название заметки равно null.</exception>
        /// <exception cref="ArgumentException">Выбрасывается в случае, 
        /// если название длиннее 50 символов.</exception>
        [JsonIgnore]
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
                // Смена даты последнего изменения
                LastModifiedAt = DateTime.Now;
            }
        }

        /// <summary>
        /// Свойство категории заметки.
        /// </summary>
        [JsonIgnore]
        public Category Category
        {
            get => _category;
            set
            {
                _category = value;
                // Смена даты последнего изменения
                LastModifiedAt = DateTime.Now;
            }
        }

        /// <summary>
        /// Свойство текста заметки.
        /// </summary>
        /// <exception cref="NullReferenceException">Выбрасывается, если текст равен null.</exception>
        [JsonIgnore]
        public string Text
        {
            get => _text;
            set
            {
                // Проверка на null
                _text = value ?? 
                        throw new NullReferenceException("Текст заметки равен null.");
                // Смена даты последнего изменения
                LastModifiedAt = DateTime.Now;
            }
        }

        /// <summary>
        /// Свойство даты создания заметки.
        /// </summary>
        [JsonIgnore]
        public DateTime CreatedAt => _createdAt;

        /// <summary>
        /// Свойство даты последнего изменения заметки.
        /// </summary>
        [JsonIgnore]
        public DateTime LastModifiedAt
        {
            get => _lastModifiedAt;
            // Изменение допустимо только самим объектом.
            private set => _lastModifiedAt = value;
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
    }
}