using StoryDb3.Model.Services;

namespace StoryDb.ConsoleTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Путь к файлу SQLite
            string dbPath = "C:\\Users\\Studia-ser\\Documents\\StoryDb\\StoryDb.db";

            // Connection string для SQLite
            string connectionString = $"Data Source={dbPath}";

            // Создаем сервис для работы с БД
            var databaseService = new DatabaseService(connectionString);

            // Создаем БД
            if (databaseService.CreateDatabase())
            {
                Console.WriteLine("База данных успешно создана!");
            }
            else
            {
                Console.WriteLine("Не удалось создать базу данных.");
            }
        }
    }
}
