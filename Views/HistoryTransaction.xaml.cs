using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using TestTaskUWP.ViewModels;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace TestTaskUWP.Views
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class HistoryTransaction : Page
    {
        public HistoryTransaction()
        {
            this.InitializeComponent();
            // Transaction = new TransactionVM();
            //DataContext = Transaction;
        }
        //public TransactionVM Transaction { get; set; }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //Попытка занести данные в кастомный DataGrid
            //TransactionContext db = new TransactionContext();
            // var data = (from d in db.Transactions select d).ToList();
        }
    }
}
