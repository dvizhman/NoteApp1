using NoteApp.Models;

namespace NoteAppUI.Enums
{
    /// <summary>
    /// Отображаемые в главном окне приложения категории заметок.
    /// </summary>
    public enum ShownCategory
    {
        Work = Category.Work,
        Home = Category.Home,
        Health = Category.Health,
        People = Category.People,
        Documents = Category.Documents,
        Financial = Category.Financial,
        Other = Category.Other,
        All
    }
}