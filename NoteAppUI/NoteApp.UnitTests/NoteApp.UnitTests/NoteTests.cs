using System;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using NoteApp.Models;
using NUnit.Framework;

namespace NoteApp.UnitTests
{
    /// <summary>
    /// Класс юнит-тестов Note
    /// </summary>
    [TestFixture]
    public class NoteTests
    {
        /// <summary>
        /// Заметка
        /// </summary>
        private Note _note;

        /// <summary>
        /// Подготовка к тестам
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            _note = new Note();
        }
        
        [TestCase(Description = "Позитивный тест Name")]
        public void NamePositiveTest()
        {
            string expected = "Название заметки";
            _note.Name = expected;
            // Тест считается успешным, если ожидаемое и фактическое имена
            // заметки совпадают.
            Assert.AreEqual(_note.Name,expected, "Значения Name различаются.");
        }

        [TestCase(Description = "Негативный тест Name. Null-значение.")]
        public void NameNullTest()
        {
            // Тест считается успешным, если при попытке присвоить null
            // в качестве имени заметки будет выброшен NullReferenceException.
            Assert.Throws<NullReferenceException>(() => _note.Name = null,
                "NullReferenceException не был выброшен.");
        }

        [TestCase(Description = "Негативный тест Name. Слишком длинное значение.")]
        public void NameTooLongValueTest()
        {
            // Тест считается успешным, если при попытке присвоить длинное
            // имя (более 50 символов) будет выброшен ArgumentExcepton.
            Assert.Throws<ArgumentException>(() => _note.Name =
                                                                "https://github.com/dvizhman/NoteApp1/tree/develop/:)",
                "ArgumentException не был выброшен.");
        }

        [TestCase(Description = "Позитивный тест Category")]
        public void CategoryPositiveTest()
        {
            var expected = Category.Health;
            _note.Category = expected;
            // Тест считается успешным, если ожидаемая и фактическая категории
            // заметки совпадают.
            Assert.AreEqual(_note.Category, expected, "Категория заметки не совпадает с ожидаемой.");
        }

        [TestCase(Description = "Позитивный тест Text")]
        public void TextPositiveTest()
        {
            var expected = "https://github.com/dvizhman/NoteApp1/";
            _note.Text = expected;
            // Тест считается успешным, если ожидаемый и фактический текста
            // заметки совпадают.
            Assert.AreEqual(_note.Text, expected, "Текст заметки отличается от ожидаемого.");
        }

        [TestCase(Description = "Негативный тест Text. Null-значение.")]
        public void TextNullTest()
        {
            // Тест считается успешным, если при попытке присвоить null
            // в качестве текста заметки будет выброшен NullReferenceException.
            Assert.Throws<NullReferenceException>(() => _note.Text = null, "NullReferenceException не был выброшен.");
        }

        [TestCase(Description = "Позитивный тест CreatedAt")]
        public void CreatedAtPositiveTest()
        {
            var expected = DateTime.Now;
            _note.CreatedAt = expected;
            // Тест считается успешным, если ожидаемая и фактическая даты
            // создания заметки совпадают.
            Assert.AreEqual(_note.CreatedAt, expected, "Фактическая дата создания заметки отличается от ожидаемой.");
        }

        [TestCase(Description = "Позитивный тест LastModifiedAt")]
        public void LastModifiedAtPositiveTest()
        {
            var expected = DateTime.Now;
            _note.LastModifiedAt = expected;
            // Тест считается успешным, если ожидаемая и фактическая даты
            // изменения заметки совпадают.
            Assert.AreEqual(_note.LastModifiedAt, expected, "Фактическая дата изменения заметки отличается от ожидаемой.");
        }

        [TestCase(Description = "Тест SetModified().")]
        public void SetModifiedTest()
        {
            var time = _note.LastModifiedAt;
            Thread.Sleep(500);
            _note.SetModified();
            // Тест считается успешным, если дата изменения заметки отличается
            // от ранее отмеченной.
            Assert.AreNotEqual(time, _note.LastModifiedAt, "Дата изменения совпадает с ранее отмеченной.");
        }

        [TestCase(Description = "Тест Clone().")]
        public void CloneTest()
        {
            var clone = _note.Clone();
            // Тест считается успешным, если объекты заметок равны по значениям.
            Assert.AreEqual(_note, clone, "Объекты заметок не равны.");
        }

        [TestCase(Description = "Негативный тест Equals(). Null-значение.")]
        public void EqualsNullTest()
        {
            // Тест считается успешным, если объект заметки не равен null.
            Assert.IsFalse(_note == null);
        }
    }
}