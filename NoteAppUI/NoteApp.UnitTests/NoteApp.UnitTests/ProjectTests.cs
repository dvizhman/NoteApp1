using System;
using System.Collections.Generic;
using System.Linq;
using NoteApp.Models;
using NUnit.Framework;

namespace NoteApp.UnitTests
{
    /// <summary>
    /// Класс юнит-тестов Project
    /// </summary>
    [TestFixture]
    public class ProjectTests
    {
        /// <summary>
        /// Проект
        /// </summary>
        private Project _project = new Project()
        {
            Notes = new List<Note>()
            {
                new Note()
                {
                    Name = "Заметка 1",
                    Category = Category.Documents,
                    Text = "Текст заметки 1",
                    CreatedAt = new DateTime(2021, 01, 01),
                    LastModifiedAt = new DateTime(2021, 01, 02)
                },
                new Note()
                {
                    Name = "Заметка 2",
                    Category = Category.Documents,
                    Text = "Текст заметки 2",
                    CreatedAt = new DateTime(2021, 01, 15),
                    LastModifiedAt = new DateTime(2021, 01, 16)
                },
                new Note()
                {
                    Name = "Заметка 3",
                    Category = Category.Health,
                    Text = "Текст заметки 3",
                    CreatedAt = new DateTime(2021, 02, 01),
                    LastModifiedAt = new DateTime(2021, 02, 02)
                }
            }
        };

        [TestCase(TestName = "Позитивный тест CurrentNote")]
        public void CurrentNotePositiveTest()
        {
            // Setup
            var expected = new Note();
            
            // Act
            expected.Name = "Заметка";
            _project.CurrentNote = expected;
            
            // Assert
            // Тест считается успешным, если фактическая текущая заметка равна ожидаемой.
            Assert.AreEqual(_project.CurrentNote, expected, "Фактическая текущая заметка не равна ожидаемой.");
        }

        [TestCase(TestName = "Позитивный тест Notes")]
        public void NotesPositiveTest()
        {
            // Setup
            var expected = new List<Note>()
            {
                new Note()
                {
                    Name = "Заметка",
                    Category = Category.Financial,
                    CreatedAt = DateTime.Today,
                    LastModifiedAt = DateTime.Now,
                    Text = "Текст"
                }
            };
            
            // Act
            _project.Notes = expected;
            
            // Assert
            // Тест считается успешным, если список заметок совпадает с ожидаемым.
            Assert.AreEqual(_project.Notes, expected, "Список заметок не совпадает с ожидаемым.");
        }

        [TestCase(TestName = "Тест SortByDate()")]
        public void SortByDateTest()
        {
            // Assert
            // Тест считается успешным, если заметки отсортируются в порядке убывания.
            Assert.AreEqual(_project.
                Notes
                .OrderByDescending(i => i.LastModifiedAt)
                .ToList(), _project.SortByDate(), "Сортировка по убыванию даты работает некорректно.");
        }

        [TestCase(TestName = "Тест SortByDate(Category)")]
        public void SortByDateFromCategoryTest()
        {
            // Assert
            // Тест считается успешным, если заметки определённой категории отсортируются
            // в порядке убывания.
            Assert.AreEqual(_project
                .Notes
                .Where(i => i.Category == Category.Documents)
                .OrderByDescending(j => j.LastModifiedAt)
                .ToList(), _project.SortByDate(Category.Documents));
        }
    }
}