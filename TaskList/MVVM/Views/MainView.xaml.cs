using TaskList.MVVM.ViewModels;

namespace TaskList.MVVM.Views;

public partial class MainView : ContentPage
{
	public MainView()
	{
		InitializeComponent();

		BindingContext = new MainViewModel();
	}
}