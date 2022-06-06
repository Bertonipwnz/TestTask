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
        public static string DbFilePath { get; set; }

        //Доступ к файлу бд в корневой папке
        public async Task GetFileDB()
        {
            StorageFile file;
            try
            {
                file = await Windows.Storage.ApplicationData.Current.LocalFolder.GetFileAsync("TestTransactions2.db");
            }
            catch
            {
                StorageFile Importedfile = await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///TestTransactions2.db"));
                file = await Importedfile.CopyAsync(ApplicationData.Current.LocalFolder);
            }
            DbFilePath = file.Path;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            Task.Run(() => GetFileDB());
            options.UseSqlite($"Data Source =TestTransactions2.db");
            base.OnConfiguring(options);
        }


    }
}
