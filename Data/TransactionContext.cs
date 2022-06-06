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
        public async Task GetFilePathDB()
        {
            StorageFile file;
            try
            {   //Если файл уже существуют используем его
                file = await Windows.Storage.ApplicationData.Current.LocalFolder.GetFileAsync("TestTransactions2.db");
            }
            catch
            {
                //Иначе копируем с папки приложения
                StorageFile Importedfile = await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///TestTransactions2.db"));
                file = await Importedfile.CopyAsync(ApplicationData.Current.LocalFolder);
            }
            DbFilePath = file.Path;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            Task.Run(() => GetFilePathDB());
            //Указываем на базу, которую используем
            options.UseSqlite($"Data Source =TestTransactions2.db");
            base.OnConfiguring(options);
        }


    }
}
