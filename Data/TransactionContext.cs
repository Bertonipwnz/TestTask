using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using TestTaskUWP.Models;
using Windows.Storage;

namespace TestTaskUWP.Data
{
    class TransactionContext : DbContext
    {
 
        public DbSet<Transaction> Transactions { get; set; }
   
        //Доступ к файлу бд в корневой папке
        public async Task GetFileDB()
        {
            //Если создан получаем путь
            try
            {
                await Windows.Storage.ApplicationData.Current.LocalFolder.GetFileAsync("TestTransactions2.db");
            }
            //В другом случаи копируем файл бд с приложения
            catch
            {
                StorageFile Importedfile = await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///TestTransactions2.db"));
                await Importedfile.CopyAsync(ApplicationData.Current.LocalFolder);
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            Task.Run(() => GetFileDB());      
            options.UseSqlite($"Data Source =TestTransactions2.db");
            base.OnConfiguring(options);
        }
    }
}
