using TaskList.MVVM.Views;

namespace TaskList
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainView();
        }
    }
}
