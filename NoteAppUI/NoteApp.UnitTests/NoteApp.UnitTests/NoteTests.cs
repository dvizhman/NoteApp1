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
        private Note _note = new Note();
        
        [TestCase(TestName = "Позитивный тест Name")]
        public void NamePositiveTest()
        {
            // Setup
            string expected = "Название заметки";
            
            // Act
            _note.Name = expected;
            
            // Assert
            // Тест считается успешным, если ожидаемое и фактическое имена
            // заметки совпадают.
            Assert.AreEqual(_note.Name,expected, "Значения Name различаются.");
        }

        [TestCase(TestName = "Негативный тест Name. Null-значение.")]
        public void NameNullTest()
        {
            // Assert
            // Тест считается успешным, если при попытке присвоить null
            // в качестве имени заметки будет выброшен NullReferenceException.
            Assert.Throws<NullReferenceException>(() => _note.Name = null,
                "NullReferenceException не был выброшен.");
        }

        [TestCase(TestName = "Негативный тест Name. Слишком длинное значение.")]
        public void NameTooLongValueTest()
        {
            // Assert
            // Тест считается успешным, если при попытке присвоить длинное
            // имя (более 50 символов) будет выброшен ArgumentExcepton.
            Assert.Throws<ArgumentException>(() => _note.Name =
                                                                "https://github.com/dvizhman/NoteApp1/tree/develop/:)",
                "ArgumentException не был выброшен.");
        }

        [TestCase(TestName = "Позитивный тест Category")]
        public void CategoryPositiveTest()
        {
            // Setup
            var expected = Category.Health;
            
            // Act
            _note.Category = expected;
            
            // Assert
            // Тест считается успешным, если ожидаемая и фактическая категории
            // заметки совпадают.
            Assert.AreEqual(_note.Category, expected, "Категория заметки не совпадает с ожидаемой.");
        }

        [TestCase(TestName = "Позитивный тест Text")]
        public void TextPositiveTest()
        {
            // Setup
            var expected = "https://github.com/dvizhman/NoteApp1/";
            
            // Act
            _note.Text = expected;
            
            // Setup
            // Тест считается успешным, если ожидаемый и фактический текста
            // заметки совпадают.
            Assert.AreEqual(_note.Text, expected, "Текст заметки отличается от ожидаемого.");
        }

        [TestCase(TestName = "Негативный тест Text. Null-значение.")]
        public void TextNullTest()
        {
            // Assert
            // Тест считается успешным, если при попытке присвоить null
            // в качестве текста заметки будет выброшен NullReferenceException.
            Assert.Throws<NullReferenceException>(() => _note.Text = null, "NullReferenceException не был выброшен.");
        }

        [TestCase(TestName = "Позитивный тест CreatedAt")]
        public void CreatedAtPositiveTest()
        {
            // Setup
            var expected = DateTime.Now;
            
            // Act
            _note.CreatedAt = expected;
            
            // Assert
            // Тест считается успешным, если ожидаемая и фактическая даты
            // создания заметки совпадают.
            Assert.AreEqual(_note.CreatedAt, expected, "Фактическая дата создания заметки отличается от ожидаемой.");
        }

        [TestCase(TestName = "Позитивный тест LastModifiedAt")]
        public void LastModifiedAtPositiveTest()
        {
            // Setup
            var expected = DateTime.Now;
            
            // Act
            _note.LastModifiedAt = expected;
            
            // Assert
            // Тест считается успешным, если ожидаемая и фактическая даты
            // изменения заметки совпадают.
            Assert.AreEqual(_note.LastModifiedAt, expected, "Фактическая дата изменения заметки отличается от ожидаемой.");
        }

        [TestCase(TestName = "Тест SetModified().")]
        public void SetModifiedTest()
        {
            // Setup
            var time = _note.LastModifiedAt;
            
            // Act
            Thread.Sleep(500);
            _note.SetModified();
            
            // Assert
            // Тест считается успешным, если дата изменения заметки отличается
            // от ранее отмеченной.
            Assert.AreNotEqual(time, _note.LastModifiedAt, "Дата изменения совпадает с ранее отмеченной.");
        }

        [TestCase(TestName = "Тест Clone().")]
        public void CloneTest()
        {
            // Setup
            var clone = _note.Clone();
            
            // Assert
            // Тест считается успешным, если объекты заметок равны по значениям.
            Assert.AreEqual(_note, clone, "Объекты заметок не равны.");
        }

        [TestCase(TestName = "Негативный тест Equals(). Null-значение.")]
        public void EqualsNullTest()
        {
            // Assert
            // Тест считается успешным, если объект заметки не равен null.
            Assert.IsFalse(_note == null);
        }
    }
}