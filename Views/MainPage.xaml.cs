using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using TestTaskUWP.Models;
using Windows.UI.Xaml.Navigation;
// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace TestTaskUWP.Views
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

        }
        private void NavigationView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {

            var item = args.InvokedItemContainer;
            // Содержимое выбранного элемента
            switch (item.Name)
            {
                case "ViewAllTransaction":
                    ContentFrame.Navigate(typeof(HistoryTransaction));
                    break;
                case "ViewScore":
                    ContentFrame.Navigate(typeof(Score));
                    break;
                case "NewOperation":
                    ContentFrame.Navigate(typeof(NewOperation));
                    break;
                case "Test":
                    ContentFrame.Navigate(typeof(TestView));
                    break;
            }
        }

        /* private void Page_Loaded(object sender, RoutedEventArgs e)
         {
             using (var db = new TransactionContext())
             {
                // Guestbook.ItemsSource = db.Transactions.ToList();
             }
         }
         private void GridView_ItemClick(object sender, ItemClickEventArgs e)
         {
             Transaction selectedTransaction = (Transaction)e.ClickedItem;
             //TransactionGrid.Header = selectedTransaction.id_Transaction;
         }
            private void Add_Transaction(object sender, RoutedEventArgs e)
            {
                using (var db = new ViewModels.TransactionContext())
                {
                    var post = new Transaction { type_Transaction = txtNewPost.Text, date_and_Time_Transaction = System.DateTime.Now };
                    db.Transactions.Add(post);
                   db.SaveChanges();

                    Guestbook.ItemsSource = db.Transactions.ToList();
                }

            }*/



    }
}
