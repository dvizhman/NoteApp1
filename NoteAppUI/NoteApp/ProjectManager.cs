using System;
using System.IO;
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
        private static readonly string AppFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
            @"\NoteApp";

        /// <summary>
        /// Файл проекта приложения
        /// </summary>
        private static readonly string NotesFile = AppFolder + @"\NoteApp.notes";
        
        /// <summary>
        /// Читает файл с диска
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <returns>Строка данных из файла</returns>
        /// <exception cref="ProjectReadingException">Ошибка чтения</exception>
        private string ReadFile(string path)
        {
            try
            {
                // Поток
                FileStream stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite, 
                    FileShare.ReadWrite, 4096, FileOptions.Asynchronous);
                // Массив байтов размером в длину потока
                byte[] bytes = new byte[stream.Length];
                stream.Read(bytes, 0, bytes.Length);
                // Закрытие потока
                stream.Close();
                // Преобразование считанных байт в строку UTF-8
                string data = System.Text.Encoding.UTF8.GetString(bytes);
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка чтения файла " + path);
            }
        }
        
        /// <summary>
        /// Записывает в файл
        /// </summary>
        /// <param name="data">Строка для записи в файл</param>
        /// <param name="path">Путь к файлу</param>
        /// <exception cref="ProjectReadingException">Ошибка записи</exception>
        private void SaveFile(string data, string path)
        {
            try
            {
                // Поток для временного файла
                FileStream stream = File.Open(path + ".temp",
                    FileMode.OpenOrCreate, FileAccess.ReadWrite);
                // Конвертирование строки в массив байтов
                byte[] bytes = System.Text.Encoding.UTF8.GetBytes(data);
                // Запись в файл
                stream.Write(bytes, 0, bytes.Length);
                // Закрытие потока
                stream.Close();
                // Замена старого файла заметок новым
                File.Delete(path);
                File.Move(path + ".temp", path);
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка записи в " + path);
            }
        }

        /// <summary>
        /// Создаёт папку
        /// </summary>
        /// <param name="path">Путь к новой папке</param>
        private void CreateFolder(string path)
        {
            try
            {
                Directory.CreateDirectory(path);
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка создания папки " + path);
            }
        }
        
        /// <summary>
        /// Загружает проект из файла
        /// </summary>
        /// <returns>Проект</returns>
        public Project Load()
        {
            // Создание папки приложения
            CreateFolder(AppFolder);
            // Создание файла проекта в случае его отсутствия
            if (!File.Exists(NotesFile))
                Create();
            // Чтение файла
            string data = ReadFile(NotesFile);
            // Десериализация данных
            Project project = JsonConvert.DeserializeObject<Project>(data);
            return project;
        }

        /// <summary>
        /// Записывает проект в файл
        /// </summary>
        /// <param name="project">Проект</param>
        public void Save(Project project)
        {
            // Создание папки приложения в случае её отсутствия
            CreateFolder(AppFolder);
            // Сериализация данных
            string data = JsonConvert.SerializeObject(project);
            // Асинхронная запись
            SaveFile(data, NotesFile);
        }

        /// <summary>
        /// Создание нового файла проекта
        /// </summary>
        /// <returns></returns>
        public void Create()
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
        /// Объект типа Lazy<T> позволяет инициализировать объект
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