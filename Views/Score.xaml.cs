using Windows.UI.Xaml.Controls;
using TestTaskUWP.ViewModels;

namespace TestTaskUWP.Views
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class Score : Page
    {
        public ShowAllMoneyViewModel Transaction { get; set; }
        public Score()
        {
            this.InitializeComponent();
            Transaction = new ShowAllMoneyViewModel();
            Transaction.LoadAmount();
        }    
    }
}
