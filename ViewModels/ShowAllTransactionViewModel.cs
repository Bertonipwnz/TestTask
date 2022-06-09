using System.Linq;
using System.Collections.ObjectModel;
using TestTaskUWP.Models;
using TestTaskUWP.Data;


namespace TestTaskUWP.ViewModels
{
    /// <summary>
    /// ViewModel для добавление новых операций
    /// </summary>
    public class ShowAllTransactionViewModel : BaseViewModel<Transaction>
    {
        public ObservableCollection<Transaction> Transactions { get; set; }

        public ShowAllTransactionViewModel()
        {
            //Запись всех данных таблицы в коллекцию
            using (TransactionContext db = new TransactionContext())
            {
                Transactions = new ObservableCollection<Transaction>(db.Transactions.ToList());
                System.Diagnostics.Debug.WriteLine("вывод сделан");
            }
        }
    }
}
