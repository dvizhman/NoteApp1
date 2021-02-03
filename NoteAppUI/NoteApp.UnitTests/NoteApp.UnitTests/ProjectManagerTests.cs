using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using NoteApp.Models;
using NUnit.Framework;

namespace NoteApp.UnitTests
{
    /// <summary>
    /// Класс юнит-тестов ProjectManager
    /// </summary>
    [TestFixture]
    public class ProjectManagerTests
    {
        [SetUp]
        public void SetUp()
        {
            if (File.Exists(ProjectManager.NotesFile))
                File.Move(ProjectManager.NotesFile, ProjectManager.NotesFile + ".test");
        }

        [TearDown]
        public void TearDown()
        {
            if (File.Exists(ProjectManager.NotesFile + ".test"))
            {
                File.Delete(ProjectManager.NotesFile);
                File.Move(ProjectManager.NotesFile  + ".test", ProjectManager.NotesFile);
            }
        }

        [TestCase(Description = "Тест создания нового файла проекта")]
        public void LoadNewTest()
        {
            if (File.Exists(ProjectManager.NotesFile))
                File.Delete(ProjectManager.NotesFile);
            var project = ProjectManager.Current.Load();
            // Тест считается успешным, если свежесозданный проект пуст.
            var expected = new Project();
            bool lol = expected.Equals(project);
            Assert.AreEqual(project, expected, "Новый проект не пуст.");
        }

        [TestCase(Description = "Тест загрузки существующего файла проекта")]
        public void LoadTest()
        {
            var project = new Project()
            {
                Notes = new List<Note>()
                {
                    new Note()
                    {
                        Name = "Заметка"
                    }
                }
            };
            if (File.Exists(ProjectManager.NotesFile))
                File.Delete(ProjectManager.NotesFile);
            File.WriteAllText(ProjectManager.NotesFile,
                JsonConvert.SerializeObject(project),
                Encoding.UTF8);
            // Тест будет считаться успешным, если загруженный проект
            // не будет отличаться от сохранённого.
            Assert.AreEqual(project, ProjectManager.Current.Load(), "Проект из файла отличается от исходного.");
        }

        [TestCase(Description = "Тест сохранения файла проекта")]
        public void SaveTest()
        {
            var project = new Project()
            {
                Notes = new List<Note>()
                {
                    new Note()
                    {
                        Name = "Заметка"
                    }
                }
            };
            if (File.Exists(ProjectManager.NotesFile))
                File.Delete(ProjectManager.NotesFile);
            ProjectManager.Current.Save(project);
            // Тест будет считаться успешным, если проект корректно
            // сохранится.
            Assert.AreEqual(File.ReadAllText(ProjectManager.NotesFile, Encoding.UTF8),
                JsonConvert.SerializeObject(project));
        }
    }
}