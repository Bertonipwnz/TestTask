using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using TestTaskUWP.Models;

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
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            using (var db = new ViewModels.TransactionContext())
            {
                Guestbook.ItemsSource = db.Transactions.ToList();
            }
        }
        private void Add_Transaction(object sender, RoutedEventArgs e)
        {
            using (var db = new ViewModels.TransactionContext())
            {
                var post = new Transaction { Type_Transaction = txtNewPost.Text };
                db.Transactions.Add(post);
               db.SaveChanges();

                Guestbook.ItemsSource = db.Transactions.ToList();
            }
           
        }
    
       
        
        }
    }
