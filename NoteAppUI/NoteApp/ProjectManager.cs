using System;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using NoteApp.Models;

namespace NoteApp
{
    /// <summary>
    /// Класс проектного менеджера.
    /// Осуществляет загрузку и сохранение данных.
    /// </summary>
    public class ProjectManager
    {
        /// <summary>
        /// Папка приложения в %APPDATA%
        /// </summary>
        public static string AppFolder => Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
            @"\NoteApp";

        /// <summary>
        /// Файл проекта приложения
        /// </summary>
        public static string NotesFile => AppFolder + @"\NoteApp.notes";

        /// <summary>
        /// Загружает проект из файла
        /// </summary>
        /// <returns>Проект</returns>
        public Project Load()
        {
            try
            {
                // Создание папки приложения
                Directory.CreateDirectory(AppFolder);
                // Создание файла проекта в случае его отсутствия
                if (!File.Exists(NotesFile))
                    Create();
                // Чтение файла
                string data = File.ReadAllText(NotesFile, Encoding.UTF8);
                // Десериализация данных
                Project project = JsonConvert.DeserializeObject<Project>(data);
                return project ?? new Project();
            }
            catch (Exception)
            {
                throw new Exception("Ошибка чтения файла " + NotesFile);
            }
        }

        /// <summary>
        /// Записывает проект в файл
        /// </summary>
        /// <param name="project">Проект</param>
        public void Save(Project project)
        {
            try
            {
                // Создание папки приложения в случае её отсутствия
                Directory.CreateDirectory(AppFolder);
                // Сериализация данных
                string data = JsonConvert.SerializeObject(project);
                // Запись
                File.WriteAllText(NotesFile, data, Encoding.UTF8);
            }
            catch (Exception)
            {
                throw new Exception("Ошибка записи в " + NotesFile);
            }
        }

        /// <summary>
        /// Создание нового файла проекта
        /// </summary>
        /// <returns></returns>
        private void Create()
        {
            Save(new Project());
        }
        
        /* Паттерн "Одиночка" позволяет гарантированно иметь
           единственный экземпляр объекта. Это достигается
           путём выставления модификатора private конструктору
           класса, а также созданием публичного статического свойства,
           ссылающегося на единственный экземпляр данного класса. */
        #region Одиночка
        
        /// <summary>
        /// Объект типа Lazy/T позволяет инициализировать объект
        /// класса T в момент первого обращения и избежать NRE.
        /// </summary>
        private static readonly Lazy<ProjectManager> Singleton = 
            new Lazy<ProjectManager>(() => new ProjectManager());

        /// <summary>
        /// Конструктор ProjectManager помечен как приватный.
        /// Таким образом, создать объект класса ProjectManager
        /// можно лишь в его же контексте.
        /// </summary>
        private ProjectManager()
        {
        }

        /// <summary>
        /// Статическое свойство, гарантирующее единственность
        /// экземпляра данного класса во всей программе.
        /// </summary>
        public static ProjectManager Current => Singleton.Value;

        #endregion
    }
}