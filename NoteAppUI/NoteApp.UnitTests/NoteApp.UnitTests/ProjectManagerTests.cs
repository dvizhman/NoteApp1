using System;
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
        private static string _testFolder = Directory.GetCurrentDirectory();
        private static string _testFile = _testFolder + @"\Notes.test";

        private void Setup()
        {
            if (File.Exists(_testFile))
            {
                File.Delete(_testFile);
            }
            File.Create(_testFile).Close();
        }
        
        [TestCase(TestName = "Тест создания нового файла проекта")]
        public void LoadNewTest()
        {
            // Setup
            Setup();
            
            // Act
            var project = ProjectManager.Current.Load(_testFolder, _testFile);
            // Тест считается успешным, если свежесозданный проект пуст.
            var expected = new Project();
            
            // Assert
            Assert.AreEqual(project, expected, "Новый проект не пуст.");
        }

        [TestCase(TestName = "Тест загрузки существующего файла проекта")]
        public void LoadTest()
        {
            // Setup
            Setup();
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
            
            // Act
            File.WriteAllText(_testFile,
                JsonConvert.SerializeObject(project),
                Encoding.UTF8);
            
            // Assert
            // Тест будет считаться успешным, если загруженный проект
            // не будет отличаться от сохранённого.
            Assert.AreEqual(project, ProjectManager.Current.Load(_testFolder, _testFile), 
                "Проект из файла отличается от исходного.");
        }

        [TestCase(TestName = "Тест загрузки повреждённого файла")]
        public void LoadCorruptedTest()
        {
            // Setup
            Setup();
            
            // Act
            File.WriteAllText(_testFile, "corrupted", Encoding.UTF8);
            
            // Assert
            Assert.Throws<Exception>(() => ProjectManager.Current.Load(_testFolder, _testFile));
        }

        [TestCase(TestName = "Тест сохранения файла проекта")]
        public void SaveTest()
        {
            // Setup
            Setup();
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
            
            // Act
            ProjectManager.Current.Save(project, _testFile);
            
            // Assert
            // Тест будет считаться успешным, если проект корректно
            // сохранится.
            Assert.AreEqual(File.ReadAllText(_testFile, Encoding.UTF8),
                JsonConvert.SerializeObject(project));
        }
    }
}