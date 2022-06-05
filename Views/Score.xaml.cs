using Windows.UI.Xaml.Controls;
using TestTaskUWP.ViewModels;
// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace TestTaskUWP.Views
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class Score : Page
    {
        public Score()
        {
            this.InitializeComponent();
            Transaction = new TransactionVM();
            Transaction.LoadAmount();
        }
        public TransactionVM Transaction { get; set; }
    }
}
